using MySql.Data.MySqlClient;
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
    
    public partial class kayıtol : Form
    {
        public kayıtol()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        MySqlConnection Con = new MySqlConnection("Server=localhost;Database=kayit;Uid=root;Pwd='';");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {

                string query = "INSERT INTO  uyeler(ad, sifre, soyad, telefon, adres, mail) values" +
                    "('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text
                    + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";


                try
                {
                    Con.Open();

                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla eklendi");
                    Con.Close();
                    nakliyat nak = new nakliyat();
                    nak.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
            private void label8_Click(object sender, EventArgs e)
            {
                //if ()
                //{
                //    MessageBox.Show("Kullanıcı Eklendi...");
                //} else
                //{
                //    try
                //    {
                //        Con.Open();
                //        MySqlConnection cmd = new MySqlConnection("insert into kayıtol (İsim,Soyisim,E-mail, Telefon no,Adres,Şifre) values ()", Con);
                //        Con.Close();
                //    } catch (Exception Ex)
                //    {
                //        MessageBox.Show("Kullanıcı Eklenemedi...");



                //    }
            } 
        }
    }

