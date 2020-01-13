using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzyfrujRSA
{
    public partial class Form1 : Form
    {
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
                txtE.Text = first2Lines[0] ?? "empty";
                txtNPublic.Text = first2Lines[1] ?? "empty";               
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
                txtD.Text = first2Lines[0] ?? "empty";
                txtNPrivate.Text = first2Lines[1] ?? "empty";
            }
        }

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
                log(line);
            }

            if (line.Length % 2 == 1)
                line += "\0";           // add null character

            // split string into list of 2 characters
            var lineChunked2 = ChunksUpto(line, 2);

            // build list of two characters in ASCII representation
            //var sb = new StringBuilder();
            //var lineChunked4 = lineChunked3.ToList();
            //lineChunked4.ForEach(i => sb.Append(GetBits(i)));
            //if (line.Length % 2 == 1)
            //    sb.Append(GetBits("\0"));   // add null character
            //Console.WriteLine(sb.ToString());

            //---
            var transformed = GetBitsEnumerable(lineChunked2);
            transformed.ToList().ForEach(x => log(x));  //Log to console

            log("Encrypting, C = M^e mod n");
            var encrypted = EncryptList(transformed);
            encrypted.ToList().ForEach(x => log(x.ToString()));  //Log to console
            log(DisplayEnumerable(encrypted));
            txtEncrypted.Text = DisplayEnumerable(encrypted);

            log("Decrypting, M' = C^d mod n");
            var decrypted = DecryptList(encrypted);
            //decrypted.ToList().ForEach(x => log(x.ToString()));  //Log to console

            var transformed2 = GetBitsEnumerable2(decrypted);
            transformed2.ToList().ForEach(x => log(x.ToString()));  //Log to console

            var myString = string.Join(string.Empty, transformed2.ToList());
            log(myString);

            // split string into list of 3 characters
            var lineChunked3 = ChunksUpto(myString, 3);           
            txtDecrypted.Text = GetCharacters(lineChunked3);
        }

        /// helpers
        ///       

        private IEnumerable<string> ChunksUpto(string str, int maxChunkSize)
        {
            for (int i = 0; i < str.Length; i += maxChunkSize)
                yield return str.Substring(i, Math.Min(maxChunkSize, str.Length - i));
        }

        public static string GetBits(string input, int totalWidth)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Encoding.UTF8.GetBytes(input))
            {
                sb.Append(Convert.ToString(b).PadLeft(totalWidth, '0'));
            }
            return sb.ToString();
        }

        private IEnumerable<string> GetBitsEnumerable(IEnumerable<string> list)
        {
            List<string> bitList = new List<string>();
            list.ToList().ForEach(item => bitList.Add(GetBits(item, 3)));
            return bitList;
        }

        private IEnumerable<BigInteger> EncryptList(IEnumerable<string> list)
        {
            List<BigInteger> bitList = new List<BigInteger>();
            list.ToList().ForEach(item => bitList.Add(EncryptValue(item)));
            return bitList;
        }

        private BigInteger EncryptValue(string m)
        {
            string n = "33965211954069027011";
            string ee = "17956500554669232013";
            return BigInteger.ModPow(BigInteger.Parse(m), BigInteger.Parse(ee), BigInteger.Parse(n));
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

        public static string DisplayEnumerable<T>(IEnumerable<T> list)
        {
            StringBuilder sb = new StringBuilder();
            list.ToList().ForEach(item => Convert.ToString(sb.Append(string.Format("{0},", item))));            
            return sb.ToString();
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
    }
}
