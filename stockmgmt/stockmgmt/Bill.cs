﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace stockmgmt
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

            Login lo = new Login();
            lo.Show();
            this.Hide();
        }

        

       
        
    }
}
