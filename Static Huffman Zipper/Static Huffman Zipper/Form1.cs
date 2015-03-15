using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Static_Huffman_Zipper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPakIn_Click(object sender, EventArgs e)
        {
            DateTime dtStart = DateTime.UtcNow;

            // check if a file is selected
            if (txtFilePath.Text == null  || fileSelector.FileName == "")
            {
                DialogResult sF = fileSelector.ShowDialog();
                txtFilePath.Text = fileSelector.FileName;
                txtOpslagNaam.Text = txtFilePath.Text + "_zipped.txt";
                return;
            }
            fileSelector.FileName = txtFilePath.Text;
            
            // read file from disk, put in an array          
            byte[] bff = File.ReadAllBytes(fileSelector.FileName);
            
            // check status, display bytesize
            txtOrigByteSize.Text = bff.Length.ToString();

            // determine frequency
            byte[] freq = dFreq.determine(bff);

            // put frequency in a doubly linked list, return a head
            node nH = piDLL.add(freq);

            // make a tree of the doubly linked list by passing the head
            // return top of the tree
            node top = DoublyLinkedList.makeTree();

            // generate a bitpattern per byte by going down the tree from the top
            string[] bitp = BitPattern.make(top);

            // substitute bytes from the source with 'coded' bitpatterns
            string rB = BitPattern.replaceBytes(bitp, bff);

            // check if string is a full byte, add zeroes if not
            string fRB = BitPattern.checkByte(rB);

            Logger.zipLog(fRB, txtOutputZip);

            // convert the string to new bytes
            byte[] cB = BitPattern.makeBytes(fRB);

            // prepare all bytes to be written to the compressed file,
            // addedzeroes|codedbytes|table by taking
            // cB, bitp for the table, number of bytes, added zeroes
            byte[] pB = BitPattern.prepareBytes(cB, bitp, fRB.Length - rB.Length);

            Logger.zipLog(pB, txtOutputZip);

            // debugging purposes
            Logger.zipLog(bitp, txtOutputZip);

            File.WriteAllBytes(txtOpslagNaam.Text, pB);
            txtZippedByteSize.Text = pB.Length.ToString();

            DateTime dtEnd = DateTime.Now;
        }

        private void txtFilePath_Enter(object sender, EventArgs e)
        {
            DialogResult sF = fileSelector.ShowDialog();
            txtFilePath.Text = fileSelector.FileName;
            txtOpslagNaam.Text = txtFilePath.Text + "_zipped.txt";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void btnUitpakken_Click(object sender, EventArgs e)
        {
            /** Unzipping **/
            // read the zipped file, put in byte-array
            byte[] rZB = File.ReadAllBytes(txtOpslagNaam.Text);

            Logger.zipLog(rZB, txtOutputUnzip);

            // get number of added zeroes to the file
            int aZ = Retriever.getAZ(rZB);

            // retrieve bitpattern table
            string[] rBT = Retriever.getPatternTable(rZB, rZB.Length);

            // debugging purposes
            Logger.zipLog(rBT, txtOutputUnzip);

            // retrieve coded bytes
            byte[] rCB = Retriever.getBytes(rZB);

            // convert the coded bytes to a string containing a binary, substract zeroes
            string cBP = BitPattern.makeBinary(rCB);
            Logger.zipLog(cBP, txtOutputUnzip);

            // rebuild bytes to unzipped file based on the binary and bitpattern-table
            byte[] rBB = BitPattern.rebuildBytes(cBP, rBT, aZ);

            File.WriteAllBytes(fileSelector.FileName + "_unzipped.txt", rBB);
            txtUnzippedByteSize.Text = rBB.Length.ToString();
            
        }
        
            }
        public static class Logger
        {
            public static void zipLog(string[] sA, TextBox t)
            {
                for (int i = 0; i < sA.Length; i++)
                {
                    if (sA[i] != null)
                    {
                        t.Text += sA[i] + Environment.NewLine;
                    }
                }
                t.Text += "------------------------------" + Environment.NewLine;
            }
            
            public static void zipLog(string s, TextBox t)
            {
                t.Text += s + Environment.NewLine;
                t.Text += "------------------------------" + Environment.NewLine;
            }
            
            public static void zipLog(byte[] bA, TextBox t)
            {
                string s = "";
                for (int i = 0; i < bA.Length; i++)
                {
                  s += i + " " + bA[i] + Environment.NewLine;
                }
                s += "------------------------------" + Environment.NewLine;
                t.Text = s;
            }
    }   
}
