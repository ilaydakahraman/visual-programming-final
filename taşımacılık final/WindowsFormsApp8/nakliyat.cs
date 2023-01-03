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
    public partial class nakliyat : Form
    {
        public nakliyat()
        {
            InitializeComponent();
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

                string query = "INSERT INTO  tasimacilik(sehir, nereden, nereye, asayi, eadet) values" +
                    "('" + comboBox1.SelectedItem.ToString() + "','" + comboBox4.SelectedItem.ToString() + "','" + comboBox5.SelectedItem.ToString()
                    + "','" + textBox1.Text + "','" + textBox3.Text + "')";


                try
                {
                    Con.Open();

                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla eklendi");
                    Con.Close();
                    nakliyatsorgulama nak = new nakliyatsorgulama();
                    nak.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}