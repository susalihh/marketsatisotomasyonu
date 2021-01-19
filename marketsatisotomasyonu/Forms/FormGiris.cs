using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketsatisotomasyonu.Forms
{
    public partial class FormGiris : Form
    {
        
        public FormGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMainMenu frm;
            if (passText.Text == "admin" && radioButton1.Checked) 
            {
                frm = new FormMainMenu("YÖNETİCİ");
                frm.Show();
                this.Hide();
            }
            else if (passText.Text == "kasa1" && radioButton2.Checked)
            {
                frm = new FormMainMenu("KASA1");
                frm.Show();
                this.Hide();
            }
            else if (passText.Text == "kasa2" && radioButton3.Checked)
            {
                frm = new FormMainMenu("KASA2");
                frm.Show();
                this.Hide();
            }
            else if (passText.Text == "kasa3" && radioButton4.Checked)
            {
                frm = new FormMainMenu("KASA3");
                frm.Show();
                this.Hide();
            }
            else if (passText.Text == "kasa4" && radioButton5.Checked)
            {
                frm = new FormMainMenu("KASA4");
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı Giriş!");
        }

        private void passText_Click(object sender, EventArgs e)
        {
            passText.Text = "";
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "YÖNETİCİ";
            //textBox2
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "KASA 1";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "KASA 2";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "KASA 3";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "KASA 4";
        }
    }
}
