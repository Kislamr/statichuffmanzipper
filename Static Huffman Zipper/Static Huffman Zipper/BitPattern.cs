using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Static_Huffman_Zipper
{
    static class BitPattern
    {
        public static string[] cBP = new string[256];

        // array definition table to put in bitpaths per byte
        public static string[] make(node top)
        {           
            cN(top, "");
            return cBP;
        }
        private static void cN(node n, string s)
        {
            // tree node is inserted, check if downleft node, if so, add to string
            // recurse over nodes while nodes are not null
            if (n.downleft != null)
            {
                cN(n.downleft, s + "0");
                cN(n.downright, s + "1");
            }
            else
            {
                cBP[n.data] = s;
            }
        }
        public static string replaceBytes(string[] rB, byte[] bff)
        {
            string mB = "";

            // iterate over the array containing bytes,
            // add bitpattern per byte (matched by array-index) to string
            for (int i = 0; i < bff.Length; i++)
            {
                mB += rB[bff[i]];
            }
            return mB;
        }
        public static string checkByte(string cB)
        {
            while (cB.Length % 8 != 0)
            {
                cB += "0";
            }
            return cB;
        }

        public static byte[] makeBytes(string mB)
        {
            byte[] nbV = new byte[mB.Length / 8];

            for (int i = 0; i < nbV.Length;i++ )
            {
                nbV[i] = BinaryConverter.BinaryToByte(mB.Substring(i*8, 8));
            }           
            return nbV;
        }

        public static byte[] prepareBytes(byte[] cB, string[] bitp, int aZ)
        {

            // determine length of the total byte array based on the inserted values
            long arrL = cB.Length*2 + aZ + cBP.Length;

            // declare a array cursor to hold position of array
            long arrC = 0;

            // define a final byte-array containing all of the values to be written
            byte[] fS = new byte[arrL];

            // insert number of added zeros
            // fS += aZ + "|";
            fS[arrC] += ((byte)(aZ));
            arrC++;
            fS[arrC] += 124;

            // add characters and bitpatterns to the string
            for (int i = 0; i < bitp.Length; i++)
            {
                // loop within the bitp string array and add values to the byte-array
                if (bitp[i] != null)
                {
                    for (int j = 0; j < bitp[i].Length;j++ )
                    {
                        arrC++;
                        if (bitp[i].Substring(j, 1) == "0")
                        {
                            fS[arrC] += 48;
                        } else if (bitp[i].Substring(j,1) == "1")
                        {
                            fS[arrC] += 49;
                        }
                        }                    
                    // end reached of bitp string array, so add separator
                    arrC++;
                    fS[arrC] += 124;

                    // add byte character
                    arrC++;
                    fS[arrC] += ((byte)(i));
                    arrC++;
                    // add separator
                    fS[arrC] += 124;
                }
            }

            // slash as separator indicating end of bitpattern-table
            fS[arrC] = 127;

            arrC++;

            // build up the string with all of the values, convert them to a array of bytes and return them
            for (int i = 0; i < cB.Length; i++)
            {
                fS[arrC] += cB[i];
                arrC++;
            }
            // first separator after coded bytes ( 124 is | )
            fS[arrC] += 124;
           
            byte[] fnS = new byte[arrC+1];

            for (int c = 0; c < arrC+1; c++)
            {
                fnS[c] = fS[c];
            }
            return fnS;
        }

        public static string makeBinary(byte[] rSA)
        {
            string n = "";

            for (int i = 0; i < rSA.Length; i++)
            {
                n += BinaryConverter.ByteToBinary(rSA[i]);
            }
            return n;
        }

        //TODO: needs looking over
        public static byte[] rebuildBytes(string rBS, string[] bPT, int aZ)
        {
            // rBS is string with complete pattern, bPT is bitpattern table, aZ is added zeroes
            // start comparing string-ranges with bitpatterns and fill in a new string with values

            int i = 0;
            int k = 1;
            long end = rBS.Length - aZ;
            byte c = 0;
            string nS = "";
            char nC;
            byte tB;
            char tC;
            
            // temp string
            string tS = "";

            while (i < end) {
            tS = rBS.Substring(i, k);
            
            while (tS != bPT[c])
            {
                c++;
                if (c == 255)
                {
                    c = 0;
                    k++;
                    tS = rBS.Substring(i, k);
                }
            }
            if (tS == bPT[c])
            {
                nS += ((char)(c));
                i = i + k;
                k = 1;
                tS = "";
                c = 0;
            }
            }

            byte[] nB = new byte[nS.Length];
            for (int x = 0; x < nS.Length; x++)
            {
                tC = char.Parse(nS.Substring(x, 1));
                nB[x] = ((byte)(tC));
            }
            return nB;
        }
    }
}
