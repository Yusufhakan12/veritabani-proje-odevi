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
    public partial class Sekreter : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=veritabaniodev;user ID=postgres;password=AB12CD34ef56.");

        public Sekreter()
        {
            InitializeComponent();
        }

        private void RandevuOlustur_Click(object sender, EventArgs e)
        {
            RandevuOlustur r1=new RandevuOlustur();
            r1.Show();
        }

        private void RandevuListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select randevubilgisi.hastakod,ad,soyad,kimlikno,tarih,randevubilgisi.doktorkod,adi,soyadi,doktorunvan,bolumad from randevubilgisi inner join hastabilgileri on randevubilgisi.hastakod=hastabilgileri.hastakod inner join doktorbilgileri on doktorbilgileri.doktorkod=randevubilgisi.doktorkod inner join polikinlik on randevubilgisi.polikinlikkod=polikinlik.polikinlikkod inner join \"public\".\"calisan\" on \"public\".\"calisan\".\"kisikod\"=\"public\".\"doktorbilgileri\".\"kisikod\" ";
             //inner join hastabilgileri on randevubilgisi.hastakod=hastabilgileri.hastakod
            /*string sorgu = "select hastakod,ad,soyad,kimlikno,tarih,doktorkod,adi,soyadi,doktorunvan,bolumad" +
                "from randevubilgisi inner join hastabilgileri on randevubilgisi.hastakod=hastabilgileri.hastakod "; */
            // "inner join doktorbilgileri on doktorbilgileri.doktorkod=randevubilgisi.doktorkod" +
            //" inner join polikinlik on randevubilgisi.polikinlikkod=polikinlik.polikinlikkod";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select sigortakontrol("+int.Parse(hastakod.Text)+")";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();

        }
    }
}
