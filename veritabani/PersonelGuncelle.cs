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
    public partial class PersonelGuncelle : Form
    {
        public PersonelGuncelle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=veritabaniodev;user ID=postgres;password=AB12CD34ef56.");
        private void PersonelListele_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT personelbilgileri.personelkod,adi,soyadi,calisanturu, kimlikno,cinsiyet,anneadi,babaadi,medeni,dogumtarihi,dogumyeri,adres,telefon,mail,il" +
               " FROM \"public\".\"personelbilgileri\" INNER JOIN  \"public\".\"calisan\"" +
               " ON \"public\".\"personelbilgileri\".\"kisikod\" = \"public\".\"calisan\".\"kisikod\" " +
               "inner join personelkisiselbilgileri on personelkisiselbilgileri.personelkod=personelbilgileri.personelkod " +
               "inner join personeliletisimbilgileri on personeliletisimbilgileri.personelkod=personelbilgileri.personelkod";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            PersonelGridView1.DataSource = ds.Tables[0];
        }

        private void PersonelKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("update  personeliletisimbilgileri set adres=@p2,telefon=@p3,mail=@p4,il=@p5 where personelkod=@p1  ", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(PersonelKod.Text));
            komut1.Parameters.AddWithValue("@p2", PersonelAdres.Text);
            komut1.Parameters.AddWithValue("@p3", PersonelTelefon.Text);
            komut1.Parameters.AddWithValue("@p4", PersonelMail.Text);
            komut1.Parameters.AddWithValue("@p5", personelgunil.Text);

            komut1.ExecuteNonQuery();

            NpgsqlCommand komut2 = new NpgsqlCommand("update  personelkisiselbilgileri  set cinsiyet=@p2,anneadi=@p3,babaadi=@p4,medeni=@p5,dogumtarihi=@p6,dogumyeri=@p7,kimlikno=@p8 where personelkisiselbilgileri.personelkod=@p1  ", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(PersonelKod.Text));
            komut2.Parameters.AddWithValue("@p2", PersonelCinsiyet.Text.ToString());
            komut2.Parameters.AddWithValue("@p3", PersonelAnneAd.Text);
            komut2.Parameters.AddWithValue("@p4", PersonelBabaAd.Text);
            komut2.Parameters.AddWithValue("@p5", PersonelMedeni.Text.ToString());
            komut2.Parameters.AddWithValue("@p6", PersonelDogumTarihi.Text);
            komut2.Parameters.AddWithValue("@p7", PersonelDogumYeri.Text.ToString());
            komut2.Parameters.AddWithValue("@p8", PersonelKimlik.Text.ToString());
            komut2.ExecuteNonQuery();

            NpgsqlCommand komut3 = new NpgsqlCommand("update \"public\".\"calisan\" set \"adi\"=@p2,\"soyadi\"=@p3 where kisikod=(select kisikod from personelbilgileri where personelkod =@p1) ", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse((PersonelKod.Text)));
            komut3.Parameters.AddWithValue("@p2", PersonelAd.Text);
            komut3.Parameters.AddWithValue("@p3", PersonelSoyad.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            this.Close();
        }
    }
}
