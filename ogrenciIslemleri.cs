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
    public partial class ogrenciIslemleri : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();
      
        public ogrenciIslemleri()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


            kayitModulu km = new kayitModulu();
            km.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            goruntule gr = new goruntule();
            gr.ShowDialog();


           
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            izinEkle iz = new izinEkle();
            iz.ShowDialog();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
          duzenleAraForm dz=new duzenleAraForm();
            dz.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            kayitSilAraForm ka = new kayitSilAraForm();
            ka.ShowDialog();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            izinTakip it = new izinTakip();
            it.ShowDialog();
        }
    }
}
