namespace Static_Huffman_Zipper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSelector = new System.Windows.Forms.OpenFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnPakIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrigByteSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZippedByteSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnzippedByteSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOpslagNaam = new System.Windows.Forms.TextBox();
            this.btnUitpakken = new System.Windows.Forms.Button();
            this.txtOutputUnzip = new System.Windows.Forms.TextBox();
            this.txtOutputZip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(23, 25);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(609, 20);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.Enter += new System.EventHandler(this.txtFilePath_Enter);
            // 
            // btnPakIn
            // 
            this.btnPakIn.Location = new System.Drawing.Point(681, 25);
            this.btnPakIn.Name = "btnPakIn";
            this.btnPakIn.Size = new System.Drawing.Size(110, 23);
            this.btnPakIn.TabIndex = 2;
            this.btnPakIn.Text = "Bestand Inpakken";
            this.btnPakIn.UseVisualStyleBackColor = true;
            this.btnPakIn.Click += new System.EventHandler(this.btnPakIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "bestandspad";
            // 
            // txtOrigByteSize
            // 
            this.txtOrigByteSize.Location = new System.Drawing.Point(23, 108);
            this.txtOrigByteSize.Name = "txtOrigByteSize";
            this.txtOrigByteSize.ReadOnly = true;
            this.txtOrigByteSize.Size = new System.Drawing.Size(142, 20);
            this.txtOrigByteSize.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "origineel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ingepakt";
            // 
            // txtZippedByteSize
            // 
            this.txtZippedByteSize.Location = new System.Drawing.Point(205, 107);
            this.txtZippedByteSize.Name = "txtZippedByteSize";
            this.txtZippedByteSize.ReadOnly = true;
            this.txtZippedByteSize.Size = new System.Drawing.Size(142, 20);
            this.txtZippedByteSize.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "uitgepakt";
            // 
            // txtUnzippedByteSize
            // 
            this.txtUnzippedByteSize.Location = new System.Drawing.Point(376, 107);
            this.txtUnzippedByteSize.Name = "txtUnzippedByteSize";
            this.txtUnzippedByteSize.ReadOnly = true;
            this.txtUnzippedByteSize.Size = new System.Drawing.Size(142, 20);
            this.txtUnzippedByteSize.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "opslagnaam";
            // 
            // txtOpslagNaam
            // 
            this.txtOpslagNaam.Location = new System.Drawing.Point(22, 64);
            this.txtOpslagNaam.Name = "txtOpslagNaam";
            this.txtOpslagNaam.Size = new System.Drawing.Size(610, 20);
            this.txtOpslagNaam.TabIndex = 15;
            // 
            // btnUitpakken
            // 
            this.btnUitpakken.Location = new System.Drawing.Point(681, 64);
            this.btnUitpakken.Name = "btnUitpakken";
            this.btnUitpakken.Size = new System.Drawing.Size(115, 23);
            this.btnUitpakken.TabIndex = 17;
            this.btnUitpakken.Text = "Bestand Uitpakken";
            this.btnUitpakken.UseVisualStyleBackColor = true;
            this.btnUitpakken.Click += new System.EventHandler(this.btnUitpakken_Click);
            // 
            // txtOutputUnzip
            // 
            this.txtOutputUnzip.Location = new System.Drawing.Point(438, 146);
            this.txtOutputUnzip.Multiline = true;
            this.txtOutputUnzip.Name = "txtOutputUnzip";
            this.txtOutputUnzip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputUnzip.Size = new System.Drawing.Size(324, 350);
            this.txtOutputUnzip.TabIndex = 23;
            // 
            // txtOutputZip
            // 
            this.txtOutputZip.Location = new System.Drawing.Point(26, 146);
            this.txtOutputZip.Multiline = true;
            this.txtOutputZip.Name = "txtOutputZip";
            this.txtOutputZip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputZip.Size = new System.Drawing.Size(324, 350);
            this.txtOutputZip.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 534);
            this.Controls.Add(this.txtOutputUnzip);
            this.Controls.Add(this.txtOutputZip);
            this.Controls.Add(this.btnUitpakken);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOpslagNaam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUnzippedByteSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtZippedByteSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrigByteSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPakIn);
            this.Controls.Add(this.txtFilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileSelector;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnPakIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrigByteSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZippedByteSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnzippedByteSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOpslagNaam;
        private System.Windows.Forms.Button btnUitpakken;
        public System.Windows.Forms.TextBox txtOutputUnzip;
        public System.Windows.Forms.TextBox txtOutputZip;

    }
}

