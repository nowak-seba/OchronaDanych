using System;
using System.Windows.Forms;
using System.Numerics;
using System.Security.Cryptography;
using System.IO;

namespace WyborKluczy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label5.UseMnemonic = false;
            //label5.Text = "ɸ(n) = (p - 1)(q - 1)";
            label5.Text = "ɸ(n)";

            btnCalculatePhiN.Text = "Calculate ɸ(n)";
        }

        /// <summary>
        /// Generate P button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BigInteger prime = RandomIntegerBelow(BigInteger.Parse(txtMax.Text));
            while (!IsProbabilyPrime(prime, 20))
            {
                prime = RandomIntegerBelow(BigInteger.Parse(txtMax.Text));
            }
            txtP.Text = prime.ToString();
        }

        /// <summary>
        /// Generate Q button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            BigInteger prime = RandomIntegerBelow(BigInteger.Parse(txtMax.Text));
            while (!IsProbabilyPrime(prime, 20))
            {
                prime = RandomIntegerBelow(BigInteger.Parse(txtMax.Text));
            }
            txtQ.Text = prime.ToString();
        }

        public bool IsProbabilyPrime(BigInteger n, int k)
        {
            bool result = false;
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            // return false if n is even -> divisbla by 2
            if (n % 2 == 0)
                return false;
            //writing n-1 as 2^s.d
            BigInteger d = n - 1;
            BigInteger s = 0;
            while (d % 2 == 0)
            {
                d >>= 1;
                s = s + 1;
            }
            for (int i = 0; i < k; i++)
            {
                BigInteger a;
                do
                {
                    a = RandomIntegerBelow(n - 2);
                }
                while (a < 2 || a >= n - 2);

                if (BigInteger.ModPow(a, d, n) == 1) return true;
                for (int j = 0; j < s - 1; j++)
                {
                    if (BigInteger.ModPow(a, 2 * j * d, n) == n - 1)
                        return true;
                }
                result = false;
            }
            return result;
        }
        public BigInteger RandomIntegerBelow(int n)
        {
            var rng = new RNGCryptoServiceProvider();
            byte[] bytes = new byte[n / 8];

            rng.GetBytes(bytes);

            var msb = bytes[n / 8 - 1];
            var mask = 0;
            while (mask < msb)
                mask = (mask << 1) + 1;

            bytes[n - 1] &= Convert.ToByte(mask);
            BigInteger p = new BigInteger(bytes);
            return p;
        }
        public BigInteger RandomIntegerBelow(BigInteger bound)
        {
            var rng = new RNGCryptoServiceProvider();
            //Get a byte buffer capable of holding any value below the bound
            var buffer = (bound << 16).ToByteArray(); // << 16 adds two bytes, which decrease the chance of a retry later on

            //Compute where the last partial fragment starts, in order to retry if we end up in it
            var generatedValueBound = BigInteger.One << (buffer.Length * 8 - 1); //-1 accounts for the sign bit
            var validityBound = generatedValueBound - generatedValueBound % bound;

            while (true)
            {
                //generate a uniformly random value in [0, 2^(buffer.Length * 8 - 1))
                rng.GetBytes(buffer);
                buffer[buffer.Length - 1] &= 0x7F; //force sign bit to positive
                var r = new BigInteger(buffer);

                //return unless in the partial fragment
                if (r >= validityBound) continue;
                return r % bound;
            }
        }

        private void btnCalculateN_Click(object sender, EventArgs e)
        {
            log("n = p*q = " + txtP.Text + " x " + txtQ.Text);
            txtN.Text = (BigInteger.Multiply(BigInteger.Parse(txtP.Text), BigInteger.Parse(txtQ.Text))).ToString();
        }

        public void log(string s)
        {
            txtLog.Text += s + "\r\n";
        }

        private void btnCalculatePhiN_Click(object sender, EventArgs e)
        {
            log("Totient = (p-1)*(q-1) = " + (BigInteger.Parse(txtP.Text) - 1) + " x " + (BigInteger.Parse(txtQ.Text) - 1));
            txtTot.Text = (BigInteger.Multiply(BigInteger.Parse(txtP.Text) - 1, BigInteger.Parse(txtQ.Text) - 1)).ToString();
        }

        private void btnGenerateE_Click(object sender, EventArgs e)
        {
            log("generating e randomely such that gcd(e,totient) = 1");
            BigInteger temp = 0;
            while (GCD_Euclidean(temp, BigInteger.Parse(txtTot.Text)) != 1)
            {
                temp = RandomIntegerBelow(BigInteger.Parse(txtTot.Text));
                log("new E =  " + temp);
            }
            txtE.Text = temp.ToString();

            /// display combined key
            txtPublicKey.Text = string.Empty;
            txtPublicKey.Text = "{" + temp.ToString() + "," + txtN.Text.ToString() + "}";
        }

        /// <summary>
        /// NWD
        /// https://pl.wikibooks.org/wiki/Kody_%C5%BAr%C3%B3d%C5%82owe/Algorytm_Euklidesa#C/C++,_C#,_Java
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public BigInteger GCD_Euclidean(BigInteger A, BigInteger B)
        {
            log("gcd(" + A + "," + B + ")");
            if (B == 0)
                return A;
            if (A == 0)
                return B;
            if (A > B)
                return GCD_Euclidean(B, A % B);
            else
                return GCD_Euclidean(B % A, A);
        }

        private void btnCalculateD_Click(object sender, EventArgs e)
        {
            BigInteger[] result = new BigInteger[3];
            result = Extended_GCD(BigInteger.Parse(txtTot.Text), BigInteger.Parse(txtE.Text));
            if (result[2] < 0)
                result[2] = result[2] + BigInteger.Parse(txtTot.Text);
            txtD.Text = result[2].ToString();

            /// display combined key
            txtPrivateKey.Text = string.Empty;
            txtPrivateKey.Text = "{" + result[2].ToString() + "," + txtN.Text.ToString() + "}";
        }

        public BigInteger[] Extended_GCD(BigInteger A, BigInteger B)
        {
            BigInteger[] result = new BigInteger[3];
            bool reverse = false;
            if (A < B) //if A less than B, switch them
            {
                BigInteger temp = A;
                A = B;
                B = temp;
                reverse = true;
            }
            log("Extended GCD");
            BigInteger r = B;
            BigInteger q = 0;
            BigInteger x0 = 1;
            BigInteger y0 = 0;
            BigInteger x1 = 0;
            BigInteger y1 = 1;
            BigInteger x = 0, y = 0;
            log(A + "\t" + " " + "\t" + x0 + "\t" + y0);
            log(B + "\t" + " " + "\t" + x1 + "\t" + y1);
            while (A % B != 0)
            {
                r = A % B;
                q = A / B;
                x = x0 - q * x1;
                y = y0 - q * y1;
                x0 = x1;
                y0 = y1;
                x1 = x;
                y1 = y;
                A = B;
                B = r;
                log(B + "\t" + r + "\t" + x + "\t" + y);
            }
            result[0] = r;
            if (reverse)
            {
                result[1] = y;
                result[2] = x;
            }
            else
            {
                result[1] = x;
                result[2] = y;
            }
            return result;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog savePublicKey = new SaveFileDialog();
            savePublicKey.FileName = "public.key";
            savePublicKey.Filter = "key files (*.key)|*.key|All files (*.*)|*.*";
            savePublicKey.FilterIndex = 2;
            savePublicKey.RestoreDirectory = true;

            if (savePublicKey.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savePublicKey.FileName, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(txtE.Text);
                    sw.WriteLine(txtN.Text);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog savePrivateKey = new SaveFileDialog();
            savePrivateKey.FileName = "private.key";
            savePrivateKey.Filter = "key files (*.key)|*.key|All files (*.*)|*.*";
            savePrivateKey.FilterIndex = 2;
            savePrivateKey.RestoreDirectory = true;

            if (savePrivateKey.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savePrivateKey.FileName, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(txtD.Text);
                    sw.WriteLine(txtN.Text);
                }
            }
        }
    }
}
