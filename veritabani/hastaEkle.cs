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
    public partial class hastaEkle : Form
    {
        public hastaEkle()
        {
            InitializeComponent();
        }
        
        private void hastaad_TextChanged(object sender, EventArgs e)
        {

        }

        private void hastasoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void hastakimlik_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void hastaEkle_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; Database=veritabaniodev;user ID=postgres;password=AB12CD34ef56.");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into iletisimbilgileri (hastakod,adres,telefon,mail,il) values(@p1,@p2,@p3,@p4,@p5) ",baglanti);
            komut1.Parameters.AddWithValue("@p1",int.Parse(hastakod.Text));
            komut1.Parameters.AddWithValue("@p2",hastaadres.Text);
            komut1.Parameters.AddWithValue("@p3",hastatelefon.Text);
            komut1.Parameters.AddWithValue("@p4",hastamail.Text);
            komut1.Parameters.AddWithValue("@p5",hastail.Text.ToString());
            komut1.ExecuteNonQuery();
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into kisiselbilgiler (hastakod,cinsiyet,anneadi,babaadi,medeni,dogumtarihi,dogumyeri,sigorta) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8) ", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(hastakod.Text));
            komut2.Parameters.AddWithValue("@p2", hastacinsiyet.Text.ToString());
            komut2.Parameters.AddWithValue("@p3", hastaanne.Text  );
            komut2.Parameters.AddWithValue("@p4", hastababa.Text);
            komut2.Parameters.AddWithValue("@p5", hastamedeni.Text.ToString());
            komut2.Parameters.AddWithValue("@p6", hastadogumtarihi.Text);
            komut2.Parameters.AddWithValue("@p7", hastadogumyeri.Text.ToString());
            komut2.Parameters.AddWithValue("@p8", hastasigorta.Text.ToString());
            komut2.ExecuteNonQuery();
            NpgsqlCommand komut3 = new NpgsqlCommand("insert into hastabilgileri (hastakod,kimlikno,ad,soyad) values(@p1,@p2,@p3,@p4) ", baglanti);
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
