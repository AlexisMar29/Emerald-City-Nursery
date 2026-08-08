namespace Exam1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstShrubs = new System.Windows.Forms.ListBox();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblshrubs = new System.Windows.Forms.Label();
            this.picshrubs = new System.Windows.Forms.PictureBox();
            this.btncart = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picshrubs)).BeginInit();
            this.SuspendLayout();
            // 
            // lstShrubs
            // 
            this.lstShrubs.FormattingEnabled = true;
            this.lstShrubs.ItemHeight = 16;
            this.lstShrubs.Location = new System.Drawing.Point(17, 30);
            this.lstShrubs.Name = "lstShrubs";
            this.lstShrubs.Size = new System.Drawing.Size(457, 196);
            this.lstShrubs.TabIndex = 0;
            this.lstShrubs.SelectedIndexChanged += new System.EventHandler(this.lstShrubs_SelectedIndexChanged);
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 16;
            this.lstCart.Location = new System.Drawing.Point(39, 30);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(444, 196);
            this.lstCart.TabIndex = 1;
            this.lstCart.SelectedIndexChanged += new System.EventHandler(this.lstCart_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstShrubs);
            this.groupBox1.Location = new System.Drawing.Point(24, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 257);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please browse our selection of beautiful Shrubs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCart);
            this.groupBox2.Location = new System.Drawing.Point(561, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 257);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your cart";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblprice);
            this.groupBox3.Controls.Add(this.lblshrubs);
            this.groupBox3.Controls.Add(this.picshrubs);
            this.groupBox3.Controls.Add(this.btncart);
            this.groupBox3.Location = new System.Drawing.Point(24, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 228);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selection Details";
            // 
            // lblprice
            // 
            this.lblprice.Location = new System.Drawing.Point(234, 94);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(178, 32);
            this.lblprice.TabIndex = 3;
            // 
            // lblshrubs
            // 
            this.lblshrubs.Location = new System.Drawing.Point(229, 35);
            this.lblshrubs.Name = "lblshrubs";
            this.lblshrubs.Size = new System.Drawing.Size(184, 31);
            this.lblshrubs.TabIndex = 2;
            // 
            // picshrubs
            // 
            this.picshrubs.Location = new System.Drawing.Point(17, 35);
            this.picshrubs.Name = "picshrubs";
            this.picshrubs.Size = new System.Drawing.Size(206, 173);
            this.picshrubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picshrubs.TabIndex = 1;
            this.picshrubs.TabStop = false;
            // 
            // btncart
            // 
            this.btncart.BackColor = System.Drawing.Color.PaleGreen;
            this.btncart.Location = new System.Drawing.Point(383, 149);
            this.btncart.Name = "btncart";
            this.btncart.Size = new System.Drawing.Size(260, 60);
            this.btncart.TabIndex = 0;
            this.btncart.Text = "Add to Cart";
            this.btncart.UseVisualStyleBackColor = false;
            this.btncart.Click += new System.EventHandler(this.btncart_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnexit.Location = new System.Drawing.Point(729, 400);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(277, 61);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.PaleGreen;
            this.btnprint.Location = new System.Drawing.Point(729, 319);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(276, 64);
            this.btnprint.TabIndex = 6;
            this.btnprint.Text = "Print Packing Slip";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1062, 552);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Emerald City Nursery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picshrubs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstShrubs;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picshrubs;
        private System.Windows.Forms.Button btncart;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblshrubs;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

