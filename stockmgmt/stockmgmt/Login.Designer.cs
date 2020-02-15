namespace stockmgmt
{
    partial class Login
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
            this.lbl_wel = new System.Windows.Forms.Label();
            this.lbl_om = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_manage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_wel
            // 
            this.lbl_wel.AutoSize = true;
            this.lbl_wel.Location = new System.Drawing.Point(268, 40);
            this.lbl_wel.Name = "lbl_wel";
            this.lbl_wel.Size = new System.Drawing.Size(62, 13);
            this.lbl_wel.TabIndex = 0;
            this.lbl_wel.Text = "WELCOME";
            // 
            // lbl_om
            // 
            this.lbl_om.AutoSize = true;
            this.lbl_om.Location = new System.Drawing.Point(226, 84);
            this.lbl_om.Name = "lbl_om";
            this.lbl_om.Size = new System.Drawing.Size(134, 13);
            this.lbl_om.TabIndex = 1;
            this.lbl_om.Text = "OM SAI MEDICAL STORE";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(119, 171);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(172, 23);
            this.btn_create.TabIndex = 2;
            this.btn_create.Text = "Generate a Bill";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_manage
            // 
            this.btn_manage.Location = new System.Drawing.Point(384, 171);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(183, 23);
            this.btn_manage.TabIndex = 3;
            this.btn_manage.Text = "Manage Medicine Stock";
            this.btn_manage.UseVisualStyleBackColor = true;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 261);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lbl_om);
            this.Controls.Add(this.lbl_wel);
            this.Name = "Login";
            this.Text = "MEDICAL SYSTEM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_wel;
        private System.Windows.Forms.Label lbl_om;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_manage;
    }
}