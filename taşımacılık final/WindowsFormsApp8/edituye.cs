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
    public partial class edituye : Form
    {
        public edituye()
        {
            InitializeComponent();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from uyeler";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        MySqlConnection Con = new MySqlConnection("Server=localhost;Database=kayit;Uid=root;Pwd='';");
        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || Name.Text == "" || sifre.Text == "" || surname.Text == "" || phone.Text == "" || address.Text == "" || mail.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update uyeler set ad='" + Name.Text + "', sifre='" + sifre.Text + "',soyad='" + surname.Text + "',telefon=" + phone.Text + ",adres=" + address.Text + ",mail='" + mail.Text + "'where id=" + key + ";";

                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla Güncellendi");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }
        int key = 0;
        private void edituye_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silmek İçin Üye Seçiniz");
            }
            else
            {

                try
                {
                    Con.Open();
                    string query = "delete from membertbl where id=" + key + ";";
                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla silindi");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            Name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            sifre.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            surname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            phone.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            address.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            mail.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            index inn = new index();
            inn.Show();
            this.Hide();

        }
    }
}
