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
    public partial class CalisanSecmeEkrani : Form
    {
        public CalisanSecmeEkrani()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelSistem p1 = new PersonelSistem();
            p1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sekreter p2 = new Sekreter();
            p2.Show();
        }

        private void doktoekran_Click(object sender, EventArgs e)
        {
            DoktorEkran p3 = new DoktorEkran();
            p3.Show();
        }
    }
}
