using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SzyfrujRSA
{
    public static class Decrypting
    {
        public static IEnumerable<BigInteger> DecryptList<T>(IEnumerable<T> list, BigInteger exp, BigInteger mod)
        {
            List<BigInteger> bitList = new List<BigInteger>();
            //list.ToList().ForEach(item => bitList.Add(DecryptValue(item.ToString())));
            list.ToList().ForEach(item => bitList.Add(DecryptValue2(item.ToString(), exp, mod)));
            return bitList;
        }

        private static BigInteger DecryptValue(string c)
        {
            string n = "33965211954069027011";
            string d = "15121732598594807605";
            return BigInteger.ModPow(BigInteger.Parse(c), BigInteger.Parse(d), BigInteger.Parse(n));
        }

        private static BigInteger DecryptValue2(string value, BigInteger exponent, BigInteger modulus)
        {
            return BigInteger.ModPow(BigInteger.Parse(value), exponent, modulus);
        }

        public static IEnumerable<string> GetBitsEnumerable2(IEnumerable<BigInteger> list)
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
    }
}
