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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayıtol kayitol = new kayıtol();
            kayitol.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            şubebaşvurusu sube = new şubebaşvurusu();
            sube.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adresiletişim iletisim = new adresiletişim();
            iletisim.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            müşteriyorumu müsteri = new müşteriyorumu();
            müsteri.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Eksik bilgi Girişi");
            }
            else if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                nakliyat nak = new nakliyat();
                nak.Show();

            }
            else
            {
                MessageBox.Show("Yanlış Id ve ya Şifre");
            }
        }
    }
    }
    

