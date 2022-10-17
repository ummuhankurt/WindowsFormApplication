using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilmArsivi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data source=UMMUHANKURT; Initial Catalog=FilmArsiv;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Create table " + textBox1.Text + "( " + textBox2.Text + " " + textBox4.Text + " , " + textBox3.Text + " " + textBox5.Text + ")", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tablo oluşturuldu");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu");
            }
        }

    }
}
