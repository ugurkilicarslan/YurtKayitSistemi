using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonu
{
    public partial class anasayfa : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();

        public anasayfa()
        {
            InitializeComponent();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            //int kat = 1;
            //odalar odalar = new odalar();

            //for (int i = 1; i < 6; i++)
            //{

            //    for (int j = 10; j < 26; j++)
            //    {
            //        for (int k = 0; k < 4; k++)
            //        {
            //            odalar.kodu = i * 100 + j;
            //            odalar.katNumarasi = kat;
            //            vt.odalar.Add(odalar);
            //            vt.SaveChanges();
            //        }

            //    }

            //    kat++;
            //}


        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ogrenciIslemleri ogrIslem = new ogrenciIslemleri();
           // this.Hide();
            ogrIslem.ShowDialog();
            
           

        }

        private void OgrIslem_Shown(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            rooms rooms = new rooms();
            rooms.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            personeller pe = new personeller();
            pe.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            finansSayfasi fd = new finansSayfasi();
            fd.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            hizmetSayfasi hs = new hizmetSayfasi();
            hs.ShowDialog();
        }
    }
}
