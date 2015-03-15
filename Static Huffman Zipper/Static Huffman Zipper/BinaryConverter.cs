using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Static_Huffman_Zipper
{
    public static class BinaryConverter
    {
        public static byte BinaryToByte(string s)
        {
            int bValue = 0;
            byte multiplier = 128;

            // iterate from position 7 to 0 in the string
            for (int i = 0; i <= 7; i++)
            {
                // * position in byte with multiplier
                bValue += int.Parse(s.Substring(i, 1)) * multiplier;

                // double multiplier according to 
                // binary system (1, 2, 4, 8, 16, 32, 64, 128)
                multiplier /= 2;
            }
            return (byte)bValue;
        }
        public static string ByteToBinary(byte b)
        {
            string s = "";
            byte multiplier = 128;

            // keep deducting multiplier if possible, add 1 to string else 0
            for (int i = 7; i >= 0; i--)
            {
                if (b - multiplier < 0)
                {
                    s += "0";
                }
                else
                {
                    s += "1";
                    b -= multiplier;
                }
                multiplier /= 2;
            }
            return s;
        }
    }
}
