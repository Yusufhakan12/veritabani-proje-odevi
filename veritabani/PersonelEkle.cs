using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace veritabani
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; Database=veritabaniodev;user ID=postgres;password=AB12CD34ef56.");
        private void PersonelKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into personeliletisimbilgileri (personelkod,adres,telefon,mail,il) values(@p1,@p2,@p3,@p4,@p5) ", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(PersonelKod.Text));
            komut1.Parameters.AddWithValue("@p2", PersonelAdres.Text);
            komut1.Parameters.AddWithValue("@p3", PersonelTelefon.Text);
            komut1.Parameters.AddWithValue("@p4", PersonelMail.Text);
            komut1.Parameters.AddWithValue("@p5", comboBox1.Text.ToString());

            komut1.ExecuteNonQuery();
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into personelkisiselbilgileri (personelkod,cinsiyet,anneadi,babaadi,medeni,dogumtarihi,dogumyeri,kimlikno) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8) ", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(PersonelKod.Text));
            komut2.Parameters.AddWithValue("@p2", PersonelCinsiyet.Text.ToString());
            komut2.Parameters.AddWithValue("@p3", PersonelAnneAd.Text);
            komut2.Parameters.AddWithValue("@p4", PersonelBabaAd.Text);
            komut2.Parameters.AddWithValue("@p5", PersonelMedeni.Text.ToString());
            komut2.Parameters.AddWithValue("@p6", PersonelDogumTarihi.Text);
            komut2.Parameters.AddWithValue("@p7", PersonelDogumYeri.Text.ToString());
            komut2.Parameters.AddWithValue("@p8", PersonelKimlik.Text.ToString());
            komut2.ExecuteNonQuery();

            NpgsqlCommand komut4 = new NpgsqlCommand("INSERT INTO \"public\".\"calisan\"(\"adi\",\"soyadi\",\"calisanturu\") values(@p1,@p2,@p3) ", baglanti);

            komut4.Parameters.AddWithValue("@p1", PersonelAd.Text);
            komut4.Parameters.AddWithValue("@p2", PersonelAd.Text);
            komut4.Parameters.AddWithValue("@p3", calisanturu.Text);
            komut4.ExecuteNonQuery();

            NpgsqlCommand komut3 = new NpgsqlCommand("INSERT INTO \"public\".\"personelbilgileri\"(\"kisikod\",\"personelkod\") values(currval('\"public\".\"calisan_kisikod_seq\"'),@p1) ", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(PersonelKod.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            this.Close();


        }
    }
}
