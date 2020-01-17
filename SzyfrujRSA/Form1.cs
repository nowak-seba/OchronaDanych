using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace SzyfrujRSA
{
    public partial class Form1 : Form
    {
        public bool _debugMode = false;
        public BigInteger _e;
        public BigInteger _d;
        public BigInteger _n;
        public string _line = string.Empty;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void butOpenPublicKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.FileName = "public.key";
            openFile.Filter = "key files (*.key)|*.key|All files (*.*)|*.*";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                var first2Lines = File.ReadLines(openFile.FileName).Take(5).ToArray();
                string _e = first2Lines[0] ?? "empty";
                txtE.Text = _e;
                this._e = BigInteger.Parse(_e);

                string _n = first2Lines[1] ?? "empty";
                txtNPublic.Text = _n;
                this._n = BigInteger.Parse(_n);
                log(string.Format("Public key (e, n): {0}, {1}", _e, _n));
            }            
        }

        private void butOpenPrivateKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.FileName = "private.key";
            openFile.Filter = "key files (*.key)|*.key|All files (*.*)|*.*";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var first2Lines = File.ReadLines(openFile.FileName).Take(5).ToArray();
                string _d = first2Lines[0] ?? "empty";
                txtD.Text = _d;
                this._d = BigInteger.Parse(_d);

                string _n = first2Lines[1] ?? "empty";
                txtNPrivate.Text = _n;
                this._n = BigInteger.Parse(_n);

                log(string.Format("Private key (d, n): {0}, {1}", _d, _n));
            }
        }

        /// <summary>
        /// Read text.txt file 
        /// </summary>
        private void butReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.FileName = "text.txt";
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;

            string line = string.Empty;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                line = File.ReadAllText(openFile.FileName);
                textFileContent.Text = line;
                log(string.Format("File content: {0}", line));
            }

            if (line.Length % 2 == 1)
                line += "\0";           // add null character

            _line = line;               // assign to public param 

            


            //log("Decrypting, M' = C^d mod n");
            //var decrypted = DecryptList(encrypted);
            ////decrypted.ToList().ForEach(x => log(x.ToString()));  //Log to console

            //var transformed2 = GetBitsEnumerable2(decrypted);
            //transformed2.ToList().ForEach(x => log(x.ToString()));  //Log to console

            //var myString = string.Join(string.Empty, transformed2.ToList());
            //log(myString);

            //// split string into list of 3 characters
            //var lineChunked3 = Helpers.ChunksUpto(myString, 3);           
            //txtDecrypted.Text = GetCharacters(lineChunked3);
        }


        

        

        private IEnumerable<BigInteger> DecryptList<T>(IEnumerable<T> list)
        {
            List<BigInteger> bitList = new List<BigInteger>();
            list.ToList().ForEach(item => bitList.Add(DecryptValue(item.ToString())));
            return bitList;
        }

        private BigInteger DecryptValue(string c)
        {
            string n = "33965211954069027011";
            string d = "15121732598594807605";
            return BigInteger.ModPow(BigInteger.Parse(c), BigInteger.Parse(d), BigInteger.Parse(n));            
        }

        

        private IEnumerable<string> GetBitsEnumerable2(IEnumerable<BigInteger> list)
        {
            List<string> slist = new List<string>();
            list.ToList().ForEach(item => slist.Add(Convert.ToString(item).PadLeft(6, '0')));
            return slist;
        }

        public static string GetCharacters(IEnumerable<string> list)
        {
            List<byte> byteList = new List<byte>();                     
            list.ToList().ForEach(item => byteList.Add(Convert.ToByte(item)));
            return Encoding.ASCII.GetString(byteList.ToArray()).TrimEnd('\0');
        }

        public void log(string s)
        {
            txtLog.Text += s + "\r\n";
        }

        private void butEncyptText_Click(object sender, EventArgs e)
        {
            // split string into list of 2 characters
            var lineChunked2 = Helpers.ChunksUpto(_line, 2);

            // build list of two characters in ASCII representation
            //var sb = new StringBuilder();
            //var lineChunked4 = lineChunked3.ToList();
            //lineChunked4.ForEach(i => sb.Append(GetBits(i)));
            //if (line.Length % 2 == 1)
            //    sb.Append(GetBits("\0"));   // add null character
            //Console.WriteLine(sb.ToString());

            //---
            var transformed = Encrypting.GetBitsEnumerable(lineChunked2);
            if (_debugMode)
                transformed.ToList().ForEach(x => log(x));  //Log to console

            log("Encrypting, C = M^e mod n");
            var encrypted = Encrypting.EncryptList(transformed);
            if(_debugMode)
                encrypted.ToList().ForEach(x => log(x.ToString()));  //Log to console
            log(Encrypting.DisplayEnumerable(encrypted));
            txtEncrypted.Text = Encrypting.DisplayEnumerable(encrypted);

        }

        private void butSaveEncryption_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveEncyptedText = new SaveFileDialog();
            saveEncyptedText.FileName = "text.enc";
            saveEncyptedText.Filter = "enc files (*.enc)|*.enc|All files (*.*)|*.*";
            saveEncyptedText.FilterIndex = 2;
            saveEncyptedText.RestoreDirectory = true;

            if (saveEncyptedText.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveEncyptedText.FileName, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(txtEncrypted.Text);
                }
            }
        }
    }
}
