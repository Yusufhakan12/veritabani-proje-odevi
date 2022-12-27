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
    public partial class PersonelCikar : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; Database=veritabaniodev;user ID=postgres;password=AB12CD34ef56.");
        public PersonelCikar()
        {
            InitializeComponent();
            string sorgu = "SELECT personelbilgileri.personelkod,adi,soyadi,calisanturu" +
              " FROM \"public\".\"personelbilgileri\" INNER JOIN  \"public\".\"calisan\"" +
              " ON \"public\".\"personelbilgileri\".\"kisikod\" = \"public\".\"calisan\".\"kisikod\" ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        
        private void PersonelSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("call personelsilinenTablo(@p1)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(PersonelSilinecekKod.Text));
            komut1.ExecuteNonQuery();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from personelbilgileri where personelkod=@p2", baglanti);
            komut2.Parameters.AddWithValue("@p2", int.Parse(PersonelSilinecekKod.Text));
            komut2.ExecuteNonQuery();
            this.Close();
        }
    }
}
