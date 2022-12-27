using Npgsql;
using System.Data;

namespace veritabani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti=new NpgsqlConnection("server=localHost;port=5432;Database=veritabaniodev;user ID=postgres;password=AB12CD34ef56.");
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT doktorbilgileri.doktorkod,adi,soyadi,calisanturu" +
               " FROM \"public\".\"doktorbilgileri\" INNER JOIN  \"public\".\"calisan\"" +
               " ON \"public\".\"doktorbilgileri\".\"kisikod\" = \"public\".\"calisan\".\"kisikod\" ";
              
            NpgsqlDataAdapter da=new NpgsqlDataAdapter(sorgu,baglanti);   
            DataSet ds=new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DoktorEkle_Click(object sender, EventArgs e)
        {
           
           DoktorEkle f2=new DoktorEkle();
            f2.Show();
        }

        private void DoktorGuncelle_Click(object sender, EventArgs e)
        {
            DoktorGuncelle f3 = new DoktorGuncelle();
            f3.Show();
        }

        private void DoktorCikar_Click(object sender, EventArgs e)
        {
            DoktorCikar f4 = new DoktorCikar();
            f4.Show();
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("SELECT doktorbilgileri.doktorkod,adi,soyadi,doktorunvan, kimlikno,cinsiyet,anneadi,babaadi,medeni,dogumtarihi,dogumyeri,adres,telefon,mail,il" +
                " FROM \"public\".\"doktorbilgileri\" INNER JOIN  \"public\".\"calisan\"" +
                " ON \"public\".\"doktorbilgileri\".\"kisikod\" = \"public\".\"calisan\".\"kisikod\" " +
                "inner join doktorkisiselbilgiler on doktorkisiselbilgiler.doktorkod=doktorbilgileri.doktorkod " +
                "inner join doktoriletisimbilgileri on doktoriletisimbilgileri.doktorkod=doktorbilgileri.doktorkod where doktorbilgileri.doktorkod = " + int.Parse((AranacakDoktor.Text)) + "", baglanti);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();

        }
    }
}