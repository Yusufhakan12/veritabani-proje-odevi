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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaSistem f1=new HastaSistem();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalisanSecmeEkrani f2=new CalisanSecmeEkrani();
            f2.Show();
        }
    }
}
