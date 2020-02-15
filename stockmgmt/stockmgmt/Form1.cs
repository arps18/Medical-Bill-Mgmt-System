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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cb_med_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_med.Text == "Strepsils")
            {
                tb_avail.Text = "50";
            }
            else if(cb_med.Text=="Paracetamol")
            {
                tb_avail.Text = "20";
            }
            else if(cb_med.Text=="Cough Syrup")
            {
                tb_avail.Text = "30";
            }
            else if(cb_med.Text=="Crocin")
            {
                tb_avail.Text = "100";
            }
            else if(cb_med.Text=="Zandu Bam")
            {
                tb_avail.Text = "20";
            }
            else if(cb_med.Text=="Dolo")
            {
                tb_avail.Text = "120";
            }
            else if(cb_med.Text=="Digest Fast")
            {
                tb_avail.Text = "30";
            }
            else if(cb_med.Text=="Endura Mass")
            {
                tb_avail.Text = "50";
            }
            else if(cb_med.Text=="Bandages")
            {
                tb_avail.Text = "100";
            }
            else if(cb_med.Text=="Relief Spray")
            {
                tb_avail.Text = "30";
            }
            else if(cb_med.Text=="Bournvita")
            {
                tb_avail.Text = "30";
            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (cb_med.Text == "Strepsils")
            {
                
                int quantity = Int32.Parse(tb_quan.Text);
                int avail = Int32.Parse(tb_avail.Text);
                int temp = quantity + avail;
                tb_tot.Text = temp.ToString();
                
            }
            MessageBox.Show("Successfully Stock Updated!");

          

      

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.Show();
            this.Hide();
        }

        

        

       
    }
}






