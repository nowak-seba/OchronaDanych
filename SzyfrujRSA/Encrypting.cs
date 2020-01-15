using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace SzyfrujRSA
{
    public static class Encrypting
    {
        public static IEnumerable<string> GetBitsEnumerable(IEnumerable<string> list)
        {
            List<string> bitList = new List<string>();
            list.ToList().ForEach(item => bitList.Add(GetBits(item, 3)));
            return bitList;
        }

        private static string GetBits(string input, int totalWidth)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Encoding.UTF8.GetBytes(input))
            {
                sb.Append(Convert.ToString(b).PadLeft(totalWidth, '0'));
            }
            return sb.ToString();
        }

        public static IEnumerable<BigInteger> EncryptList(IEnumerable<string> list)
        {
            List<BigInteger> bitList = new List<BigInteger>();
            list.ToList().ForEach(item => bitList.Add(EncryptValue(item)));
            return bitList;
        }

        private static BigInteger EncryptValue(string m)
        {
            string n = "33965211954069027011";
            string ee = "17956500554669232013";
            return BigInteger.ModPow(BigInteger.Parse(m), BigInteger.Parse(ee), BigInteger.Parse(n));
        }

        public static string DisplayEnumerable<T>(IEnumerable<T> list)
        {
            StringBuilder sb = new StringBuilder();
            list.ToList().ForEach(item => Convert.ToString(sb.Append(string.Format("{0},", item))));
            return sb.ToString();
        }
    }
}
