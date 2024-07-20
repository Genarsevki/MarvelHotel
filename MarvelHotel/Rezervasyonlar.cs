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
    public partial class Rezervasyonlar : Form
    {
        public Rezervasyonlar()
        {
            InitializeComponent();
        }

        private void Rezervasyonlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'marvelHotelDataSet.Rezervasyonlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.rezervasyonlarTableAdapter.Fill(this.marvelHotelDataSet.Rezervasyonlar);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Ana_sayfa anasayfa = new Ana_sayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
