using System;
using System.Data;
using System.Windows.Forms;

namespace MarvelHotel
{
    public partial class MusteriBilgi : Form
    {
        SqlFunc Sql = new SqlFunc();

        public MusteriBilgi()
        {
            InitializeComponent();
        }

        private void MusteriBilgi_Load(object sender, EventArgs e)
        {
            // Müşteri bilgilerini doldurur
            this.musterilerTableAdapter.Fill(this.marvelHotelDataSet1.Musteriler);

            // ComboBox'a müşterileri yükle
            DataTable dtMusteriler = Sql.Select("SELECT musteri_id, ad, soyad FROM Musteriler");
            comboBoxMusteriler.DataSource = dtMusteriler;
            comboBoxMusteriler.DisplayMember = "ad";
            comboBoxMusteriler.ValueMember = "musteri_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ana sayfayı açar ve mevcut formu gizler
            Ana_sayfa ana_Sayfa = new Ana_sayfa();
            ana_Sayfa.Show();
            this.Hide();
        }

       

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            // ComboBox'tan seçili müşteriyi sil
            int musteriId = Convert.ToInt32(comboBoxMusteriler.SelectedValue);

            // Silme sorgusu
            string sorgu = string.Format("DELETE FROM Musteriler WHERE musteri_id = {0}", musteriId);

            // Sorguyu çalıştır
            int etkilenenSatirSayisi = Sql.UpdateDelete(sorgu);

            // Etkilenen satır sayısına göre işlem başarılı mı kontrol et
            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Müşteri kaydı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Yeniden yükle
                this.musterilerTableAdapter.Fill(this.marvelHotelDataSet1.Musteriler);
            }
            else
            {
                MessageBox.Show("Müşteri kaydı silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
