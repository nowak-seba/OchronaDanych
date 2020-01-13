using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace AsciiCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string sampleText = "KO ko";

            byte[] bs = { 075, 086 };
            string someString = Encoding.ASCII.GetString(bs);

            Console.WriteLine(someString);

            Console.WriteLine(GetBits(sampleText));

            Console.WriteLine("Encrypting, C = M^e mod n");
            //string m = "1234";
            string m = "075079032107111";
            string n = "33965211954069027011";
            string e = "17956500554669232013";
            var encrypted = BigInteger.ModPow(BigInteger.Parse(m), BigInteger.Parse(e), BigInteger.Parse(n));
            Console.WriteLine(encrypted.ToString());

            Console.WriteLine("Decrypting, M' = C^d mod n");
            string c = encrypted.ToString();
            string d = "15121732598594807605";

            var decrypted = BigInteger.ModPow(BigInteger.Parse(c), BigInteger.Parse(d), BigInteger.Parse(n));
            Console.WriteLine(decrypted.ToString());

            Console.Write("Decrypted text: ");
            byte[] decr = { 75, 079,032,107, 111 };
            string decrString = Encoding.ASCII.GetString(decr);
            Console.WriteLine(decrString);

            Console.WriteLine("Press a key to exit...");
            Console.ReadKey();
        }

        public static string GetBits(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Encoding.UTF8.GetBytes(input))
            {               
                sb.Append(Convert.ToString(b).PadLeft(3, '0'));
            }
            return sb.ToString();
        }
    }
}
