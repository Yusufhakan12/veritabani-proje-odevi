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
    public partial class RandevuOlustur : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=veritabaniodev;user ID=postgres;password=AB12CD34ef56.");

        public RandevuOlustur()
        {
            InitializeComponent();
            string sorgu = "SELECT doktorbilgileri.doktorkod,adi,soyadi,calisanturu from \"public\".\"calisan\"  INNER JOIN \"public\".\"doktorbilgileri\"  ON \"public\".\"calisan\".\"kisikod\" = \"public\".\"doktorbilgileri\".\"kisikod\" ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Doktorbilgileri.DataSource = ds.Tables[0];

            string sorgu2 = "select * from hastabilgileri";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, baglanti);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            HastaBilgileri.DataSource = ds2.Tables[0];

            string sorgu3 = "select * from polikinlik";
            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(sorgu3, baglanti);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            Polikinlikler.DataSource = ds3.Tables[0];
        }

        private void RandevuListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into randevubilgisi (hastakod,tarih,doktorkod,polikinlikkod) values (@p1,@p2,@p3,@p4) ", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse((HastaKoduRndv.Text)));
            komut1.Parameters.AddWithValue("@p2", TarihRndv.Text.ToString());
            komut1.Parameters.AddWithValue("@p3", int.Parse((DoktorKodRndv.Text)));
            komut1.Parameters.AddWithValue("@p4", int.Parse((polikinlikkodrndv.Text)));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            this.Close();

        }
    }
}
