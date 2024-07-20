using System;
using System.Data;
using System.Windows.Forms;

namespace MarvelHotel
{
    public partial class RezervasyonForm : Form
    {
        SqlFunc Sql = new SqlFunc();

        public RezervasyonForm()
        {
            InitializeComponent();

            // Müşteri verilerini yükle
            DataTable dtMusteriler = Sql.Select("SELECT musteri_id, ad, soyad FROM Musteriler");
            comboBox1.DataSource = dtMusteriler;
            comboBox1.DisplayMember = "ad";
            comboBox1.ValueMember = "musteri_id";

            // Oda verilerini yükle
            DataTable dtOdalar = Sql.Select("SELECT oda_id, oda_numarasi FROM Odalar");
            comboBox2.DataSource = dtOdalar;
            comboBox2.DisplayMember = "oda_numarasi";
            comboBox2.ValueMember = "oda_id";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // ComboBox'lardan seçilen müşteri ID'sini ve oda ID'sini al
            int musteriId = Convert.ToInt32(comboBox1.SelectedValue);
            int odaId = Convert.ToInt32(comboBox2.SelectedValue);
            DateTime girisTarihi = dateTimePicker1.Value;
            DateTime cikisTarihi = dateTimePicker2.Value;
            decimal toplamUcret = Convert.ToDecimal(textBox1.Text);

            // Oda kaydı için gerekli SQL sorgusu
            string sorgu = string.Format("INSERT INTO Rezervasyonlar (musteri_id, oda_id, giris_tarihi, cikis_tarihi, toplam_ucret) " +
                                         "VALUES ({0}, {1}, '{2}', '{3}', {4})",
                                         musteriId, odaId, girisTarihi.ToString("yyyy-MM-dd"), cikisTarihi.ToString("yyyy-MM-dd"), toplamUcret);

            // Sorguyu çalıştır
            int etkilenenSatirSayisi = Sql.Insert(sorgu);

            // Etkilenen satır sayısına göre işlem başarılı mı kontrol et
            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Müşteri otel odasına başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Müşteri otel odasına kaydedilirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Ana_sayfa ana_Sayfa = new Ana_sayfa();
            ana_Sayfa.Show();
            this.Hide();
        }

        private void RezervasyonForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            // ComboBox'lardan seçilen müşteri ID'sini ve oda ID'sini al
            int musteriId = Convert.ToInt32(comboBox1.SelectedValue);
            int odaId = Convert.ToInt32(comboBox2.SelectedValue);

            // Rezervasyon silme için gerekli SQL sorgusu
            string sorgu = string.Format("DELETE FROM Rezervasyonlar WHERE musteri_id = {0} AND oda_id = {1}", musteriId, odaId);

            // Sorguyu çalıştır
            int etkilenenSatirSayisi = Sql.UpdateDelete(sorgu);

            // Etkilenen satır sayısına göre işlem başarılı mı kontrol et
            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Müşteri rezervasyonu başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Müşteri rezervasyonu silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
