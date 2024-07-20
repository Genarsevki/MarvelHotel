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
    public partial class Ana_sayfa : Form
    {
        public Ana_sayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //ODALAR
        {
            OdalarBilgisi odalarBilgisi = new OdalarBilgisi();
            odalarBilgisi.Show();   
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) //MÜŞTERİLER
        {
            MusteriBilgi musteriler = new MusteriBilgi();
            musteriler.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e) //MÜŞTERİ KAYDI
        {
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.Show();
            this.Hide();
        }

        private void btnRez_Click(object sender, EventArgs e)
        {
            RezervasyonForm rezervasyonyap = new RezervasyonForm();
            rezervasyonyap.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rezervasyonlar rezervasyonbilgi = new Rezervasyonlar();
            rezervasyonbilgi.Show();
            this.Hide();
        }

       

        
    }
}
