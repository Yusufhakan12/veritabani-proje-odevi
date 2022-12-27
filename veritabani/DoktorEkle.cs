using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabani
{
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=veritabaniodev;user ID=postgres;password=AB12CD34ef56.");
        private void DoktorKaydet_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            

            NpgsqlCommand komut2 = new NpgsqlCommand("insert into doktoriletisimbilgileri (adres,telefon,mail,doktorkod,il) values(@p1,@p2,@p3,@p4,@p5) ", baglanti);
            komut2.Parameters.AddWithValue("@p4", int.Parse((DoktorKod.Text)));
            komut2.Parameters.AddWithValue("@p1", DoktorAdres.Text);
            komut2.Parameters.AddWithValue("@p2", DoktorTelefon.Text);
            komut2.Parameters.AddWithValue("@p3", DoktorMail.Text);
            komut2.Parameters.AddWithValue("@p5", comboBox1.Text.ToString());
            komut2.ExecuteNonQuery();


            NpgsqlCommand komut3 = new NpgsqlCommand("insert into doktorkisiselbilgiler (kimlikno,cinsiyet,anneadi,babaadi,medeni,dogumtarihi,dogumyeri,doktorkod) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8) ", baglanti);
            komut3.Parameters.AddWithValue("@p1", DoktorKimlik.Text);
            komut3.Parameters.AddWithValue("@p2", DoktorCinsiyet.Text.ToString());
            komut3.Parameters.AddWithValue("@p3", DoktorAnneAd.Text);
            komut3.Parameters.AddWithValue("@p4", DoktorBabaAd.Text);
            komut3.Parameters.AddWithValue("@p5", DoktorMedeni.Text.ToString());
            komut3.Parameters.AddWithValue("@p6", DoktorDogumTarihi.Text);
            komut3.Parameters.AddWithValue("@p7", DoktorDogumYeri.Text.ToString());
            komut3.Parameters.AddWithValue("@p8", int.Parse((DoktorKod.Text)));
            komut3.ExecuteNonQuery();


            NpgsqlCommand komut5 = new NpgsqlCommand("INSERT INTO \"public\".\"calisan\"(\"adi\",\"soyadi\",\"calisanturu\") values(@p1,@p2,@p3) ", baglanti);

            komut5.Parameters.AddWithValue("@p1", DoktorAd.Text);
            komut5.Parameters.AddWithValue("@p2", DoktorSoyad.Text);
            komut5.Parameters.AddWithValue("@p3", calisanturu.Text);
            komut5.ExecuteNonQuery();

            NpgsqlCommand komut1 = new NpgsqlCommand("INSERT INTO \"public\".\"doktorbilgileri\"(\"kisikod\",\"doktorkod\",\"doktorunvan\") values(currval('\"public\".\"calisan_kisikod_seq\"'),@p1,@p2) ", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse((DoktorKod.Text)));
            komut1.Parameters.AddWithValue("@p2", DoktorUnvan.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            this.Close();


        }

        private void DoktorCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
