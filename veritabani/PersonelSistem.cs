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
    public partial class PersonelSistem : Form
    {
        public PersonelSistem()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=veritabaniodev;user ID=postgres;password=AB12CD34ef56.");
        private void PersonelListele_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT personelbilgileri.personelkod,adi,soyadi,calisanturu" +
              " FROM \"public\".\"personelbilgileri\" INNER JOIN  \"public\".\"calisan\"" +
              " ON \"public\".\"personelbilgileri\".\"kisikod\" = \"public\".\"calisan\".\"kisikod\" ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void PersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle f6 = new PersonelEkle();
            f6.Show();
        }

        private void PersonelGuncelle_Click(object sender, EventArgs e)
        {
            PersonelGuncelle f7=new PersonelGuncelle();
            f7.Show();
        }

        private void PersonelCikar_Click(object sender, EventArgs e)
        {
            PersonelCikar f8 = new PersonelCikar();
            f8.Show();
        }

        private void PersonelSistem_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("SELECT personelbilgileri.personelkod,adi,soyadi,calisanturu, kimlikno,cinsiyet,anneadi,babaadi,medeni,dogumtarihi,dogumyeri,adres,telefon,mail,il" +
               " FROM \"public\".\"personelbilgileri\" INNER JOIN  \"public\".\"calisan\"" +
               " ON \"public\".\"personelbilgileri\".\"kisikod\" = \"public\".\"calisan\".\"kisikod\" " +
               "inner join personelkisiselbilgileri on personelkisiselbilgileri.personelkod=personelbilgileri.personelkod " +
               "inner join personeliletisimbilgileri on personeliletisimbilgileri.personelkod=personelbilgileri.personelkod where personelbilgileri.personelkod = " + int.Parse((AranacakPersonel.Text)) + "", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
