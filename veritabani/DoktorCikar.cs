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
    public partial class DoktorCikar : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; Database=veritabaniodev;user ID=postgres;password=AB12CD34ef56.");

        public DoktorCikar()
        {
            InitializeComponent();
            string sorgu = "SELECT doktorbilgileri.doktorkod,adi,soyadi,calisanturu" +
               " FROM \"public\".\"doktorbilgileri\" INNER JOIN  \"public\".\"calisan\"" +
               " ON \"public\".\"doktorbilgileri\".\"kisikod\" = \"public\".\"calisan\".\"kisikod\" ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        private void DoktorSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("call doktorsilinenTablo(@p1)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(DoktorSilinecekKod.Text));
            komut1.ExecuteNonQuery();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from doktorbilgileri where doktorkod=@p2", baglanti);
            komut2.Parameters.AddWithValue("@p2", int.Parse(DoktorSilinecekKod.Text));
            komut2.ExecuteNonQuery();
            this.Close();
        }
    }
}
