using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace SzyfrujRSA
{
    public static class Encrypting
    {
        /// <summary>
        /// Build list of two characters converted into ASCII
        /// </summary>
        /// <param name="list">Text splitted by two characters</param>
        /// <returns></returns>
        public static IEnumerable<string> GetBitsEnumerable(IEnumerable<string> list)
        {
            List<string> bitList = new List<string>();
            list.ToList().ForEach(item => bitList.Add(GetBits(item, 3)));
            return bitList;
        }

        /// <summary>
        /// Take ASCII value for each character and build string of two ASCII values
        /// </summary>
        /// <param name="input">Pair of two characters</param>
        /// <param name="totalWidth">Length of represented for each character</param>
        /// <returns></returns>
        private static string GetBits(string input, int totalWidth)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Encoding.UTF8.GetBytes(input))
            {
                sb.Append(Convert.ToString(b).PadLeft(totalWidth, '0'));
            }
            return sb.ToString();
        }

        /// <summary>
        /// Encypt each value (pair of convered ASCII characters) with 'e' and 'n'
        /// </summary>
        /// <param name="list">List of two characters converted into ASCII</param>
        /// <param name="exponent">'e' from Public key</param>
        /// <param name="modulus">'n' from Public key</param>
        /// <returns></returns>
        public static IEnumerable<BigInteger> EncryptList(IEnumerable<string> list, BigInteger exponent, BigInteger modulus)
        {
            List<BigInteger> bitList = new List<BigInteger>();
            list.ToList().ForEach(val => bitList.Add(EncryptValue(val, exponent, modulus)));
            return bitList;
        }

        /// <summary>
        /// Encrypting, C = M^e mod n 
        /// </summary>
        /// <param name="value">The number to raise to the exponent power.</param>
        /// <param name="exponent">The exponent to raise value by.</param>
        /// <param name="modulus">The number by which to divide value raised to the exponent power.</param>
        /// <returns>The remainder after dividing value exponent by modulus.</returns>
        private static BigInteger EncryptValue(string value, BigInteger exponent, BigInteger modulus)
        {
            return BigInteger.ModPow(BigInteger.Parse(value), exponent, modulus);
        }

        /// <summary>
        /// Build a string of comma delimated values 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string DisplayEnumerable<T>(IEnumerable<T> list)
        {
            StringBuilder sb = new StringBuilder();
            list.ToList().ForEach(item => Convert.ToString(sb.Append(string.Format("{0},", item))));
            return sb.ToString();
        }
    }
}
