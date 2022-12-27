using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabani
{
    public partial class HastaSistem : Form
    {
        public HastaSistem()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=veritabaniodev;user ID=postgres;password=AB12CD34ef56.");
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select hastabilgileri.hastakod,  ad, soyad, kimlikno, cinsiyet, anneadi,babaadi, medeni,dogumyeri from hastabilgileri inner join kisiselbilgiler on hastabilgileri.hastakod = kisiselbilgiler.hastakod  ";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
            
        }

        private void hastaekle_Click(object sender, EventArgs e)
        {
            hastaEkle f4 =  new hastaEkle();
            f4.Show();
        }

        private void hastaguncelle_Click(object sender, EventArgs e)
        {
            HastaGuncelle f5= new HastaGuncelle();
            f5.Show();
        }

        private void hastacikar_Click(object sender, EventArgs e)
        {
            HastaCikar f6 = new HastaCikar();
            f6.Show();
        }

        private void HastaAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("select hastabilgileri.hastakod,  ad, soyad, kimlikno, cinsiyet, anneadi,babaadi, medeni,dogumyeri,adres,telefon,mail,il from hastabilgileri inner join kisiselbilgiler on hastabilgileri.hastakod = kisiselbilgiler.hastakod inner join iletisimbilgileri on hastabilgileri.hastakod = iletisimbilgileri.hastakod where hastabilgileri.hastakod= " + int.Parse(textBox1.Text) + "", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            NpgsqlCommand komut2 = new NpgsqlCommand("select * from recete where recete.hastakod= " + int.Parse(textBox1.Text) + "", baglanti);
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(komut2);
            DataSet ds2 = new DataSet();    
            da2.Fill(ds2);
            recetedata.DataSource = ds2.Tables[0];

            NpgsqlCommand komut3 = new NpgsqlCommand("select tahlilad from hastabilgileri inner join tahliller on hastabilgileri.tahlilkod=tahliller.tahlilkod where hastabilgileri.hastakod=" + int.Parse(textBox1.Text) +"", baglanti);
            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(komut3);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            tahlildata.DataSource = ds3.Tables[0];
            baglanti.Close();
        }

        private void recetedata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
