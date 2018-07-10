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
    public partial class finansSayfasi : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();

        public finansSayfasi()
        {
            InitializeComponent();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            double giderToplam=0, mutfakGideri=0, personelGideri=0, temizlikGideri=0, digerGiderler=0;

            var gider = vt.gider.ToList();

            if (gider.Count > 0)
            {

                foreach (var item in gider)
                {
                    if (item.giderTuru == "Mutfak")
                    {

                        mutfakGideri += double.Parse(item.tutar.ToString());
                    }
                    if (item.giderTuru == "Personel")
                    {

                        personelGideri += double.Parse(item.tutar.ToString());
                    }
                    if (item.giderTuru == "Diger")
                    {

                        digerGiderler += double.Parse(item.tutar.ToString());
                    }
                    if (item.giderTuru == "Temizlik")
                    {

                        temizlikGideri += double.Parse(item.tutar.ToString());
                    }

                    giderToplam += double.Parse(item.tutar.ToString());

                }
            }

           

            var ogrenciler = vt.ogrenci.ToList();
            double gelir = 800 * ogrenciler.Count;
            finansalDurum fd = new finansalDurum();
            fd.taksitlbl.Text = gelir.ToString()+" ₺";
            fd.personellbl.Text = personelGideri.ToString()+" ₺" ;
            fd.digerlbl.Text = digerGiderler.ToString() + " ₺";
            fd.temizliklbl.Text = temizlikGideri.ToString() + " ₺";
            fd.yemekgiderlbl.Text = mutfakGideri.ToString() + " ₺";

            
            double fark = gelir - giderToplam;
            fd.fark.Text = fark.ToString();
            if (fark < 0)
                fd.fark.BackColor = Color.Red;
            else
                fd.fark.ForeColor = Color.Green;

            fd.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            odemeYap oy = new odemeYap();
            oy.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            giderler gd = new giderler();
            gd.ShowDialog();
        }
    }
}
