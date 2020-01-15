using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzyfrujRSA
{
    public static class Helpers
    {
        public static IEnumerable<string> ChunksUpto(string str, int maxChunkSize)
        {
            for (int i = 0; i < str.Length; i += maxChunkSize)
                yield return str.Substring(i, Math.Min(maxChunkSize, str.Length - i));
        }

    }
}
