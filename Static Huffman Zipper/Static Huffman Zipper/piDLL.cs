using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Static_Huffman_Zipper
{
    class piDLL
    {
        public static node add (byte[] fL) {
        // put values in the doubly linked list, sorted on frequency
        for (int i = 0; i < fL.Length; i++)
        {
        // iterate through array, if not 0 add index + frequency
            if (fL[i] != 0)
            {
                // Console.WriteLine("char-freq: " + fL[i]);
                DoublyLinkedList.addNode(i, fL[i]);
            }
        }
        return DoublyLinkedList.getHead();
        }
    }
}
