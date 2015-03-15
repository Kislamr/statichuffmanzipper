using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Static_Huffman_Zipper
{
    // node object
    class node
    {
        /*                
         *     PREV <--(DATA)--> NEXT
         *            /      \ 
         *           V        V
         *       DOWNLEFT  DOWNRIGHT
         */
        public node prev;
        public node downleft;

        public int data;
        public int freq;

        public node next;
        public node downright;
    }
}
