using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarvelHotel
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataReader dr;
        SqlCommand com;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
       
        private void ButtonGirisYap_Click(object sender, EventArgs e)
        {
           
            string user = TextBoxKullanici.Text;
            string pass = TextBoxSifre.Text;
            using (SqlConnection con = new SqlConnection(@"Data Source = GENARS_VIC\SQLEXPRESS01; Initial Catalog = MarvelHotel; Integrated Security = True;"))
            {
                string query = "Select * from Personel where kulAdi = @user and sifre_hash  = @pass";
                using(SqlCommand com = new SqlCommand(query,con))
                {
                    com.Parameters.AddWithValue("@user", user);
                    com.Parameters.AddWithValue("@pass",pass);
                    con.Open();
                    try
                    {
                        using(SqlDataReader dr = com.ExecuteReader())
                        {
                            if(dr.Read())
                            {
                                Ana_sayfa anasayfa = new Ana_sayfa();
                                MessageBox.Show("Giriş Başarılı");
                                this.Hide();
                                anasayfa.Show();
                               
                            }
                            else
                            {
                                MessageBox.Show("Giriş Hatalı");
                              
                            }
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Hata :",ex.Message);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TextBoxSifre.PasswordChar = '\0';
            }

            else
            {
                TextBoxSifre.PasswordChar = '*';
            }
        }
    }
}
