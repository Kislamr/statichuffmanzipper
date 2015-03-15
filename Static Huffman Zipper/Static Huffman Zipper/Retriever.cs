using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Static_Huffman_Zipper
{
    static class Retriever
    {
        public static byte[] getBytes(byte[] Ba)
        {
            long lC = 0;

            // determine start of codes bytes in the byte-array
            while (Ba[lC] != 127)
            {
                lC++;
            }
            lC++;
                        
            byte[] rB = new byte[Ba.Length - 1 - lC];
            
            long d = 0;
            while (lC < Ba.Length - 1) 
            {
                rB[d] = Ba[lC];
                lC++;
                d++;
            }
            return rB;
        }

        public static string[] getPatternTable(byte[] rB, long aL)
        {
            // aL is defined length of the array
            // put values in a string array until a '/' is reached
            string[] bPT = new string[255];

            // temp string
            string tBP = "";

            // assuming bitpattern starts at byte array 2
            long sP = 2;

            while (rB[sP] != 127)
            {
                if (rB[sP] != 124)
                {
                    tBP += ((char)(rB[sP]));
                }
                else
                {
                    sP++;
                    bPT[rB[sP]] = tBP;
                    tBP = "";
                    sP++;
                }
                if (rB[sP] != 127)
                {
                    sP++;
                }
            }
            return bPT;
        }

        public static int getByteNr(byte[] rB)
        {
            return rB[0];
        }

        public static int getAZ(byte[] rB)
        {
            return rB[0];
        }
    }
}
