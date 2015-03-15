using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Static_Huffman_Zipper
{
    public class dFreq
    {
        public static byte[] determine(byte[] x)
        {
            // setup an array with 256 values (bytes) range 0-255
            byte[] freqTable = new byte[256];

            // start counting byte frequency
            for (int i = 0; i < x.Length; i++)
            {
                byte c = ((byte)x[i]);
                freqTable[c] += 1;
            }
            return freqTable;
        }
    }
}
