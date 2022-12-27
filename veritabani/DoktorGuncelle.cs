using Microsoft.VisualBasic;
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
    public partial class DoktorGuncelle : Form
    {
        public DoktorGuncelle()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=veritabaniodev;user ID=postgres;password=AB12CD34ef56.");
        private void DoktorKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("update doktoriletisimbilgileri set adres=@p1,telefon=@p2,mail=@p3,il=@p4  where doktoriletisimbilgileri.doktorkod=@p4 ", baglanti);
            komut2.Parameters.AddWithValue("@p4", int.Parse((DoktorKod.Text)));
            komut2.Parameters.AddWithValue("@p1", DoktorAdres.Text);
            komut2.Parameters.AddWithValue("@p2", DoktorTelefon.Text);
            komut2.Parameters.AddWithValue("@p3", DoktorMail.Text);
            komut2.Parameters.AddWithValue("@p3", doktorgunil.Text);
            komut2.ExecuteNonQuery();



            NpgsqlCommand komut3 = new NpgsqlCommand("update  doktorkisiselbilgiler set kimlikno=@p1,cinsiyet=@p2,anneadi=@p3,babaadi=@p4,medeni=@p5,dogumtarihi=@p6,dogumyeri=@p7 where doktorkod=@p8 ", baglanti);
            komut3.Parameters.AddWithValue("@p1", DoktorKimlik.Text);
            komut3.Parameters.AddWithValue("@p2", DoktorCinsiyet.Text.ToString());
            komut3.Parameters.AddWithValue("@p3", DoktorAnneAd.Text);
            komut3.Parameters.AddWithValue("@p4", DoktorBabaAd.Text);
            komut3.Parameters.AddWithValue("@p5", DoktorMedeni.Text.ToString());
            komut3.Parameters.AddWithValue("@p6", DoktorDogumTarihi.Text);
            komut3.Parameters.AddWithValue("@p7", DoktorDogumYeri.Text.ToString());
            komut3.Parameters.AddWithValue("@p8", int.Parse((DoktorKod.Text)));

            komut3.ExecuteNonQuery();

            NpgsqlCommand komut4 = new NpgsqlCommand("update \"public\".\"doktorbilgileri\" set \"doktorunvan\"=@p2 where doktorbilgileri.doktorkod=@p1 ", baglanti);
            komut4.Parameters.AddWithValue("@p2", DoktorUnvan.Text);
            komut4.Parameters.AddWithValue("@p1", int.Parse((DoktorKod.Text)));
            komut4.ExecuteNonQuery();

            NpgsqlCommand komut1 = new NpgsqlCommand("update  \"public\".\"calisan\" set \"adi\"=@p2,\"soyadi\"=@p3 where kisikod = (select kisikod from doktorbilgileri where doktorkod =@p1) ", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse((DoktorKod.Text)));
            komut1.Parameters.AddWithValue("@p2", DoktorAd.Text);
            komut1.Parameters.AddWithValue("@p3", DoktorSoyad.Text);
            komut1.ExecuteNonQuery();

            
            baglanti.Close();
            this.Close();

        }

        private void DoktorAra_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT doktorbilgileri.doktorkod,adi,soyadi,doktorunvan, kimlikno,cinsiyet,anneadi,babaadi,medeni,dogumtarihi,dogumyeri,adres,telefon,mail,il" +
                " FROM \"public\".\"doktorbilgileri\" INNER JOIN  \"public\".\"calisan\"" +
                " ON \"public\".\"doktorbilgileri\".\"kisikod\" = \"public\".\"calisan\".\"kisikod\" " +
                "inner join doktorkisiselbilgiler on doktorkisiselbilgiler.doktorkod=doktorbilgileri.doktorkod " +
                "inner join doktoriletisimbilgileri on doktoriletisimbilgileri.doktorkod=doktorbilgileri.doktorkod";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DoktorGridView1.DataSource = ds.Tables[0];
        }
    }
}
