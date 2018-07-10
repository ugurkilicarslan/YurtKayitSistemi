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
    public partial class izinEkle : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();
        public izinEkle()
        {
            InitializeComponent();
        }

        private void metroButton2_MouseEnter(object sender, EventArgs e)
        {
            aciklamaLabel.Visible = true;
        }

        private void metroButton2_MouseLeave(object sender, EventArgs e)
        {
            aciklamaLabel.Visible = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var ogr = vt.ogrenci.Where(s => s.tckNo == metroTextBox1.Text).FirstOrDefault();

            if (ogr == null)
            {
                MessageBox.Show("Lutfen gerli bir kimlik numarası giriniz");
            }

            else
            {

                ogrenciKarti ogKarti = new ogrenciKarti();
                ogKarti.ogrIsimlbl.Text = ogr.adi;
                ogKarti.ogrOdalbl.Text = ogr.kalacagiOda.ToString();
                ogKarti.ogrTcklbl.Text = ogr.tckNo;
                ogKarti.ogrTellbl.Text = ogr.telefon;
                ogKarti.richTextBox1.Text = ogr.adresi;
                ogKarti.ShowDialog();

            }
        }

        private void metroLabel5_MouseEnter(object sender, EventArgs e)
        {
            gidecegiKisilbl.Visible = true;
        }

        private void metroLabel5_MouseLeave(object sender, EventArgs e)
        {
            gidecegiKisilbl.Visible = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var ogrenci = vt.ogrenci.Where(s => s.tckNo == metroTextBox1.Text).FirstOrDefault();

            if (ogrenci != null)
            {
                izin izin = new izin();
                izin.tckNo = metroTextBox1.Text;
                izin.gidecegiKisiTel = metroTextBox2.Text;
                izin.gidecegiAdres = richTextBox1.Text;
                izin.gidisTarihi = dateTimePicker1.Value;
                izin.donusTarihi = dateTimePicker2.Value;

                vt.izin.Add(izin);
                vt.SaveChanges();

            }

            else
            {
                MessageBox.Show("Bu Kimlik Numarasına Ait Herhangi Bir Ogrenci Yoktur !");
            }

           
        }
    }
}
