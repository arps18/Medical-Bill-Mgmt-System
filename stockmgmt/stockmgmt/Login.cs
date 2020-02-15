using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace stockmgmt
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            lbl_wel.Font =new Font("Comic Sans MS", 25);
            lbl_om.Font = new Font("Comic Sans MS", 15);
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Bill newform = new Bill();
            newform.Show();
            this.Hide();
        }

      



       
       

      

       
    }
}
