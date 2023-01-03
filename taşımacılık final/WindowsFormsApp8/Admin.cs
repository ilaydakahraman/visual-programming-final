using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Eksik bilgi Girişi");
            }
            else if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                edituye edit = new edituye();
                edit.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Yanlış Id ve ya Şifre");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index anasayfa = new index();
            anasayfa.Show();
            this.Hide();
        }
    }
}
