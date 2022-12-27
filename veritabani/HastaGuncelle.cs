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
    public partial class HastaGuncelle : Form
    {
        public HastaGuncelle()
        {
            InitializeComponent();
        }

        private void HastaGuncelle_Load(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=veritabaniodev;user ID=postgres;password=AB12CD34ef56.");
        private void HastaListele_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * from hastabilgileri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            HastaGridView1.DataSource = ds.Tables[0];
        }

        private void HastaKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("update  iletisimbilgileri set adres  =@p2,telefon=@p3,mail=@p4,il=@p5   where hastakod=@p1 ", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(hastakod.Text));
            komut1.Parameters.AddWithValue("@p2", HastaAdres.Text);
            komut1.Parameters.AddWithValue("@p3", HastaTelefon.Text);
            komut1.Parameters.AddWithValue("@p4", HastaMail.Text);
            komut1.Parameters.AddWithValue("@p5", Hastail.Text.ToString());
            komut1.ExecuteNonQuery();
            NpgsqlCommand komut2 = new NpgsqlCommand("update kisiselbilgiler set cinsiyet=@p2,anneadi=@p3,babaadi=@p4,medeni=@p5,dogumtarihi=@p6,dogumyeri=@p7,sigorta=@p8 where hastakod=@p1  ", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(hastakod.Text));
            komut2.Parameters.AddWithValue("@p2", hastacinsiyet.Text.ToString());
            komut2.Parameters.AddWithValue("@p3", textBox2.Text);
            komut2.Parameters.AddWithValue("@p4", textBox3.Text);
            komut2.Parameters.AddWithValue("@p5", comboBox3.Text.ToString());
            komut2.Parameters.AddWithValue("@p6", dateTimePicker1.Text);
            komut2.Parameters.AddWithValue("@p7", comboBox4.Text.ToString());
            komut2.Parameters.AddWithValue("@p8", comboBox2.Text.ToString());
            komut2.ExecuteNonQuery();
            NpgsqlCommand komut3 = new NpgsqlCommand("update hastabilgileri set kimlikno=@p2,ad=@p3,soyad=@p4 where hastakod=@p1 ", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(hastakod.Text));
            komut3.Parameters.AddWithValue("@p2", hastakimlik.Text);
            komut3.Parameters.AddWithValue("@p3", hastaad.Text);
            komut3.Parameters.AddWithValue("@p4", hastasoyad.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            this.Close();
        }
    }
}
