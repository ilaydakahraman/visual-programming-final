using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp8
{


    public partial class nakliyatsorgulama : Form
    {
        public nakliyatsorgulama()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterByName();
        }
        MySqlConnection Con = new MySqlConnection("Server=localhost;Database=kayit;Uid=root;Pwd='';");
        private void FilterByName()
        {
            Con.Open();
            string query = "select * from tasimacilik where MName='" + textBox1.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from tasimacilik";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void nakliyatsorgulama_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index ind = new index();
            ind.Show();
            this.Hide();
        }
    }
}
