using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Static_Huffman_Zipper
{   
    static class DoublyLinkedList
    {
        static node head;
        static node n;
        static node cursor;
        public static string[] matchChar = new string[255];

        public static void addNode(int pData, int pFreq)
        {
            n = new node();
            n.data = pData;
            n.freq = pFreq;

            if (head == null)
            {
                head = n;
                head.prev = null;
            }
            // there is only a head, so add a node to head
            else if (head.next == null)
            {
                if (head.freq <= n.freq) { n.prev = head; head.next = n; n.next = null; }
                else if (head.freq > n.freq)
                {
                    insertNodeBeforeHead();
                }
            }
            // head is not null, traverse the list to add freq
            else
            {
                // traverse starting from head
                cursor = head;

                // check if value needs to be inserted before head
                if (cursor.freq > n.freq)
                {
                    insertNodeBeforeHead();
                    // head = n;
                }
                // if not, start traversing the list, unless tail is reached:
                while (cursor.next != null)
                {
                    // check if new node needs to be inserted, if not, continue traversing
                    if (cursor.freq <= n.freq)
                    {
                        cursor = cursor.next;
                    }
                    // if it is, insert node
                    else
                    {
                        insertNode();
                        break;
                    }
                }
                // check if tail is reached, if so, decide were to put new node
                if (cursor.next == null)
                {
                    // new node needs to be appended
                    if (cursor.freq <= n.freq)
                    {
                        appendNode();
                    }
                    // new node needs to be inserted
                    else
                    {
                        insertNode();
                    }
                }
            }
        }
        public static node getHead()
        {
            return head;
        }

        private static void insertNodeBeforeHead()
        {
            n.next = head;
            head.prev = n;
            head = n;
        }

        private static void appendNode()
        {
            cursor.next = n;
            n.prev = cursor;
        }

        private static void insertNode()
        {
            n.prev = cursor.prev;
            cursor.prev.next = n;
            n.next = cursor;
            cursor.prev = n;

        }

        public static node makeTree()
        {
            // make a tree from the list
            cursor = head;
            int add;

            while (head.next.next != null)
            {
                add = head.freq + head.next.freq;
                DoublyLinkedList.addNode(0, add);
                n.downright = head.next;
                n.downleft = head;
                head = head.next.next;
                add = 0;
                //printList();
            }
            if (head.next != null)
            {
                add = head.freq + head.next.freq;
                DoublyLinkedList.addNode(0, add);
                n.downright = head.next;
                n.downleft = head;
                head = head.next.next;
                add = 0;
            }
            n.data = n.downleft.freq + n.downright.freq;
            return n;
        }

        public static int length()
        {
            int counter = 1;
            n = head;
            while (n.next != null)
            {
                n = n.next;
                counter++;
            }
            return counter;
        }

        // output methods, printList, printHeader, printLine
        public static void printList()
        {
            cursor = head;
            int c = 0;
            while (cursor != null)
            {
                // new line if 7 nodes are printed to make it more readable
                if (c % 7 == 0) { Console.WriteLine(""); }
                Console.Write("(" + Convert.ToString(cursor.freq) + "/"
                    + Convert.ToString(cursor.data) + "/"
                    + Convert.ToChar(cursor.data)
                    + ") ");
                c++;
                cursor = cursor.next;
            }
            cursor = head;
            printLine();
        }

        public static void printHeader()
        {
            Console.Write("List of nodes:  ( frequency / data / readable char ) ");
            Console.WriteLine("Connection: ( downleft | downright) ");
            printLine();
        }

        private static void printLine()
        {
            Console.WriteLine("");
            Console.Write("----------------------------------------------");
        }
    }
}