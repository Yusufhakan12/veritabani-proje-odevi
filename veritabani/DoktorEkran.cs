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
    public partial class DoktorEkran : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=veritabaniodev;user ID=postgres;password=AB12CD34ef56.");

        public DoktorEkran()
        {
            InitializeComponent();
            string sorgu = "SELECT randevubilgisi.hastakod,ad,soyad from randevubilgisi inner join hastabilgileri on randevubilgisi.hastakod=hastabilgileri.hastakod";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            randevulistesi.DataSource = ds.Tables[0];

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ReceteNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ilac_TextChanged(object sender, EventArgs e)
        {

        }

        private void ilacAdet_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kullanim_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoktorTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void yazdır_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into recete (hastakod,ilacadet,kullanim,tarih,ilackod,recetead) values (@p1,@p2,@p3,@p4,@p5,@p6) ", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse((hastakod.Text)));
            komut1.Parameters.AddWithValue("@p2", int.Parse((ilacAdet.Text)));
            komut1.Parameters.AddWithValue("@p3", Kullanim.Text.ToString());
            komut1.Parameters.AddWithValue("@p4", ReceteTarih.Text.ToString());
            komut1.Parameters.AddWithValue("@p5", int.Parse((ilackod.Text)));
            komut1.Parameters.AddWithValue("@p6", ReceteNo.Text.ToString());
            komut1.ExecuteNonQuery();
            baglanti.Close();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ilaclar_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * from ilac";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ilacdata.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * from tahliller";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            tahlildata.DataSource = ds.Tables[0];
        }

        private void DoktorEkran_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void randevulistesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("update hastabilgileri set tahlilkod=@p1 ", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse((tahlilkod.Text)));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            this.Close();
        }

       }

}
