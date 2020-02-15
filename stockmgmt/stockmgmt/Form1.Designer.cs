namespace stockmgmt
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
            this.lbl_med = new System.Windows.Forms.Label();
            this.lbl_quan = new System.Windows.Forms.Label();
            this.cb_med = new System.Windows.Forms.ComboBox();
            this.tb_quan = new System.Windows.Forms.TextBox();
            this.lbl_comp = new System.Windows.Forms.Label();
            this.cb_comp = new System.Windows.Forms.ComboBox();
            this.lbl_avail = new System.Windows.Forms.Label();
            this.tb_avail = new System.Windows.Forms.TextBox();
            this.lbl_mfg = new System.Windows.Forms.Label();
            this.dtp_mfg = new System.Windows.Forms.DateTimePicker();
            this.lbl_exp = new System.Windows.Forms.Label();
            this.dtp_exp = new System.Windows.Forms.DateTimePicker();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.tb_tot = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_med
            // 
            this.lbl_med.AutoSize = true;
            this.lbl_med.Location = new System.Drawing.Point(56, 34);
            this.lbl_med.Name = "lbl_med";
            this.lbl_med.Size = new System.Drawing.Size(84, 13);
            this.lbl_med.TabIndex = 0;
            this.lbl_med.Text = "Medicine Name:";
            // 
            // lbl_quan
            // 
            this.lbl_quan.AutoSize = true;
            this.lbl_quan.Location = new System.Drawing.Point(56, 81);
            this.lbl_quan.Name = "lbl_quan";
            this.lbl_quan.Size = new System.Drawing.Size(49, 13);
            this.lbl_quan.TabIndex = 1;
            this.lbl_quan.Text = "Quantity:";
            // 
            // cb_med
            // 
            this.cb_med.FormattingEnabled = true;
            this.cb_med.Items.AddRange(new object[] {
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
            this.cb_med.Location = new System.Drawing.Point(146, 34);
            this.cb_med.Name = "cb_med";
            this.cb_med.Size = new System.Drawing.Size(234, 21);
            this.cb_med.TabIndex = 2;
            this.cb_med.SelectedIndexChanged += new System.EventHandler(this.cb_med_SelectedIndexChanged);
            // 
            // tb_quan
            // 
            this.tb_quan.Location = new System.Drawing.Point(146, 74);
            this.tb_quan.Name = "tb_quan";
            this.tb_quan.Size = new System.Drawing.Size(234, 20);
            this.tb_quan.TabIndex = 3;
            // 
            // lbl_comp
            // 
            this.lbl_comp.AutoSize = true;
            this.lbl_comp.Location = new System.Drawing.Point(56, 120);
            this.lbl_comp.Name = "lbl_comp";
            this.lbl_comp.Size = new System.Drawing.Size(85, 13);
            this.lbl_comp.TabIndex = 4;
            this.lbl_comp.Text = "Company Name:";
            // 
            // cb_comp
            // 
            this.cb_comp.FormattingEnabled = true;
            this.cb_comp.Items.AddRange(new object[] {
            "Cipla",
            "Sun Pharmaceutical Industries Limited",
            "Johnson & Johnson",
            "Novartis",
            "Roche.",
            "Pfizer. ",
            "Sanofi. ",
            "Merck",
            "Hindustan Unilever"});
            this.cb_comp.Location = new System.Drawing.Point(148, 120);
            this.cb_comp.Name = "cb_comp";
            this.cb_comp.Size = new System.Drawing.Size(232, 21);
            this.cb_comp.TabIndex = 5;
            // 
            // lbl_avail
            // 
            this.lbl_avail.AutoSize = true;
            this.lbl_avail.Location = new System.Drawing.Point(56, 170);
            this.lbl_avail.Name = "lbl_avail";
            this.lbl_avail.Size = new System.Drawing.Size(84, 13);
            this.lbl_avail.TabIndex = 6;
            this.lbl_avail.Text = "Available Stock:";
            // 
            // tb_avail
            // 
            this.tb_avail.Location = new System.Drawing.Point(146, 170);
            this.tb_avail.Name = "tb_avail";
            this.tb_avail.Size = new System.Drawing.Size(234, 20);
            this.tb_avail.TabIndex = 7;
            // 
            // lbl_mfg
            // 
            this.lbl_mfg.AutoSize = true;
            this.lbl_mfg.Location = new System.Drawing.Point(57, 218);
            this.lbl_mfg.Name = "lbl_mfg";
            this.lbl_mfg.Size = new System.Drawing.Size(54, 13);
            this.lbl_mfg.TabIndex = 8;
            this.lbl_mfg.Text = "Mfg Date:";
            // 
            // dtp_mfg
            // 
            this.dtp_mfg.Location = new System.Drawing.Point(148, 218);
            this.dtp_mfg.Name = "dtp_mfg";
            this.dtp_mfg.Size = new System.Drawing.Size(200, 20);
            this.dtp_mfg.TabIndex = 9;
            this.dtp_mfg.Value = new System.DateTime(2020, 2, 15, 0, 0, 0, 0);
            // 
            // lbl_exp
            // 
            this.lbl_exp.AutoSize = true;
            this.lbl_exp.Location = new System.Drawing.Point(57, 270);
            this.lbl_exp.Name = "lbl_exp";
            this.lbl_exp.Size = new System.Drawing.Size(64, 13);
            this.lbl_exp.TabIndex = 10;
            this.lbl_exp.Text = "Expiry Date:";
            // 
            // dtp_exp
            // 
            this.dtp_exp.Location = new System.Drawing.Point(148, 270);
            this.dtp_exp.Name = "dtp_exp";
            this.dtp_exp.Size = new System.Drawing.Size(200, 20);
            this.dtp_exp.TabIndex = 11;
            this.dtp_exp.Value = new System.DateTime(2020, 2, 15, 0, 0, 0, 0);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(12, 426);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 12;
            this.btn_up.Text = "Update";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(125, 426);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Add New";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(333, 426);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(57, 326);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(111, 13);
            this.lbl_total.TabIndex = 15;
            this.lbl_total.Text = "Total Medicine Stock:";
            // 
            // tb_tot
            // 
            this.tb_tot.Location = new System.Drawing.Point(174, 323);
            this.tb_tot.Name = "tb_tot";
            this.tb_tot.Size = new System.Drawing.Size(234, 20);
            this.tb_tot.TabIndex = 16;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(223, 426);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 23);
            this.btn_back.TabIndex = 17;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 461);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tb_tot);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.dtp_exp);
            this.Controls.Add(this.lbl_exp);
            this.Controls.Add(this.dtp_mfg);
            this.Controls.Add(this.lbl_mfg);
            this.Controls.Add(this.tb_avail);
            this.Controls.Add(this.lbl_avail);
            this.Controls.Add(this.cb_comp);
            this.Controls.Add(this.lbl_comp);
            this.Controls.Add(this.tb_quan);
            this.Controls.Add(this.cb_med);
            this.Controls.Add(this.lbl_quan);
            this.Controls.Add(this.lbl_med);
            this.Name = "Form1";
            this.Text = "Medicine Stock Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_med;
        private System.Windows.Forms.Label lbl_quan;
        private System.Windows.Forms.ComboBox cb_med;
        private System.Windows.Forms.TextBox tb_quan;
        private System.Windows.Forms.Label lbl_comp;
        private System.Windows.Forms.ComboBox cb_comp;
        private System.Windows.Forms.Label lbl_avail;
        private System.Windows.Forms.TextBox tb_avail;
        private System.Windows.Forms.Label lbl_mfg;
        private System.Windows.Forms.DateTimePicker dtp_mfg;
        private System.Windows.Forms.Label lbl_exp;
        private System.Windows.Forms.DateTimePicker dtp_exp;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox tb_tot;
        private System.Windows.Forms.Button btn_back;
    }
}

