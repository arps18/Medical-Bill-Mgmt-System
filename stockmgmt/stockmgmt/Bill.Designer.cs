namespace stockmgmt
{
    partial class Bill
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cust = new System.Windows.Forms.TextBox();
            this.tb_doc = new System.Windows.Forms.TextBox();
            this.lbl_medi = new System.Windows.Forms.Label();
            this.clb_medi = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BILL SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doctor Name:";
            // 
            // tb_cust
            // 
            this.tb_cust.Location = new System.Drawing.Point(179, 57);
            this.tb_cust.Name = "tb_cust";
            this.tb_cust.Size = new System.Drawing.Size(199, 20);
            this.tb_cust.TabIndex = 3;
            // 
            // tb_doc
            // 
            this.tb_doc.Location = new System.Drawing.Point(179, 94);
            this.tb_doc.Name = "tb_doc";
            this.tb_doc.Size = new System.Drawing.Size(199, 20);
            this.tb_doc.TabIndex = 4;
            // 
            // lbl_medi
            // 
            this.lbl_medi.AutoSize = true;
            this.lbl_medi.Location = new System.Drawing.Point(81, 136);
            this.lbl_medi.Name = "lbl_medi";
            this.lbl_medi.Size = new System.Drawing.Size(61, 13);
            this.lbl_medi.TabIndex = 5;
            this.lbl_medi.Text = "Medicines: ";
            // 
            // clb_medi
            // 
            this.clb_medi.FormattingEnabled = true;
            this.clb_medi.Items.AddRange(new object[] {
            "Paracetamol",
            "Strepsils",
            "Cough Syrup",
            "Crocin",
            "Iodex",
            "Zandu Bam",
            "Dolo",
            "Digest Fast",
            "Perfumes",
            "Endura Mass",
            "Women Horlicks",
            "Bournvita",
            "Bandages",
            "Relief Spray",
            "Volini",
            "Move",
            "Syringe",
            "Cotton Pad",
            "TusQ-dx",
            "Amodep-AT",
            "Cloben-G",
            "Cheston Cold",
            "Lopox",
            "Avil",
            "Cyclopalm"});
            this.clb_medi.Location = new System.Drawing.Point(179, 136);
            this.clb_medi.Name = "clb_medi";
            this.clb_medi.Size = new System.Drawing.Size(120, 109);
            this.clb_medi.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(377, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 108);
            this.listBox1.TabIndex = 7;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(321, 419);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 23);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(120, 419);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(107, 23);
            this.btn_print.TabIndex = 9;
            this.btn_print.Text = "Print Bill";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Qty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price:";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 483);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.clb_medi);
            this.Controls.Add(this.lbl_medi);
            this.Controls.Add(this.tb_doc);
            this.Controls.Add(this.tb_cust);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bill";
            this.Text = "Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cust;
        private System.Windows.Forms.TextBox tb_doc;
        private System.Windows.Forms.Label lbl_medi;
        private System.Windows.Forms.CheckedListBox clb_medi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}