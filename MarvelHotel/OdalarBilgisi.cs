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
    public partial class OdalarBilgisi : Form
    {
        public OdalarBilgisi()
        {
            InitializeComponent();
        }

        private void OdalarBilgisi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'marvelHotelDataSet.Odalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odalarTableAdapter.Fill(this.marvelHotelDataSet.Odalar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ana_sayfa ana_Sayfa = new Ana_sayfa();
            ana_Sayfa.Show();
                this.Hide();
        }
    }
}
