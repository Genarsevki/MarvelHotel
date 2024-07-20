using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarvelHotel
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlFunc Sql = new SqlFunc();
        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string sorgu = "Insert Into Musteriler (ad, soyad, cinsiyet, dogum_tarihi, telefon, email, tckno) Values ('" +
                           textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" +
                           dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '" + maskedTextBox1.Text+ "', '" + textBox5.Text + "', '" +
                           maskedTextBox2.Text + "')";
            Sql.Insert(sorgu);





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana_sayfa ana_Sayfa = new Ana_sayfa();
            ana_Sayfa.Show();
            this.Hide();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//ODA1
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
