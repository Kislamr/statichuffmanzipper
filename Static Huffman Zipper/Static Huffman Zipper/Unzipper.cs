using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Static_Huffman_Zipper
{
    class Unzipper
    {
        public static String unzip(byte[] x)  
        {
            // array table for bitpaths
            string[] bitPaths = new string[255];

            // string to construct bytes
            string byteConstruct = "";

            // define an array position
            int aPos = 0;

            // define an array iterator
            int aIterator = 2;

            while (aIterator < x.Length)
            {
                // check the array for a | seperator
                while (x[aIterator] != 124)
                {
                    bitPaths[x[aPos]] += Convert.ToChar(x[aIterator]);
                    aIterator++;
                }
                aIterator++;
                aPos = aIterator;
                
                // check for a semicolon, after which size is stated
                if (x[aIterator] != 59)
                {
                    aIterator = aIterator + 2;
                }
                else { 
                    // semicolon separater is reached, end the while loop
                    break; 
                    }
            }
            aIterator++;

            while (x[aIterator] != 58)
            {
                byteConstruct += Convert.ToChar(x[aIterator]);
                aIterator++;
            }
            // define and put length of the byte and added zeroes
            aIterator++;
            int bytePattern = int.Parse(byteConstruct);
            byteConstruct = "";
            byteConstruct += Convert.ToChar(x[aIterator]);
            int addBytes = int.Parse(byteConstruct);
            byteConstruct = "";

            string codedBytes = "";

            // ultimatly, read out the bytes
            aIterator += 2;
            while (aIterator != x.Length)
            {
                byteConstruct += Convert.ToChar(x[aIterator]);
                aIterator++;
            }
            for (int i = 0; i < byteConstruct.Length; i++)
            {
                char n = Convert.ToChar(byteConstruct.Substring(i, 1));
                Console.WriteLine(n);
                byte b = ((byte)n);
                Console.WriteLine(b);
                string appender = BinaryConverter.ByteToBinary(b);
                Console.WriteLine(appender);
                codedBytes += appender;
            }
            
            Console.WriteLine(codedBytes);

            // rebuild a string to write back to the uncompressed file
            // compare values in the codedBytes starting from position 0 
            // with the bitPaths array, if so, place the character based on the
            // array-index into the string
           // string decompression = "";

            for (int i = 0; i < codedBytes.Length; i++ )
            {

            }


            Console.ReadKey();
            return null; 
        }
        

    }
}
 