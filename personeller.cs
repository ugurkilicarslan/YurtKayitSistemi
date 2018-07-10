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
    public partial class personeller : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();
        public personeller()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            personel personel = new personel();
            personelKarti pk = new personelKarti();
            pk.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            personelGoruntuleAraForm pa = new personelGoruntuleAraForm();
            pa.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            personelSil ps = new personelSil();
            ps.ShowDialog();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            personelDuzenleAraForm pa = new personelDuzenleAraForm();
            pa.ShowDialog();
        }
    }
}
