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
    public partial class duzenleAraForm : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();
        public duzenleAraForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            var ogrenci = vt.ogrenci.Where(s => s.tckNo == metroTextBox1.Text).FirstOrDefault();
            if (ogrenci != null)
            {
                rooms rom = new rooms();
                ogrenci.kalacagiOda=rom.odaAdi;
                rom.ShowDialog();

                vt.SaveChanges();


            }
            else
            {

                MessageBox.Show("Lutfen gecerli bir kimlik numarası giriniz!");
            }
            

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var ogrenci = vt.ogrenci.Where(s => s.tckNo == metroTextBox1.Text).FirstOrDefault();


            if (ogrenci != null)
            {
                ogrenciDuzenle km = new ogrenciDuzenle();
                km.pictureBox1.ImageLocation = ogrenci.fotograf;
                km.okulTxt.Text = ogrenci.okul;
                km.bolumTxt.Text = ogrenci.bolum;
                km.sozlesmeSuresicb.SelectedIndex = (int)ogrenci.sozlesmeSuresi;
                km.adiLbl.Text = ogrenci.adi;
                km.tcknoLbl.Text = ogrenci.tckNo;
                km.soyadilbl.Text = ogrenci.soyadi;
                km.sinifcb.SelectedIndex =((int) ogrenci.sinif)-1;
                km.adresRtxt.Text = ogrenci.adresi.ToString();
                km.telefonTxt.Text = ogrenci.telefon.ToString();
                km.veliTelefonuTxt.Text = ogrenci.veliTelefon.ToString();
              
                km.ShowDialog();
            }

            else
            {

                MessageBox.Show("Lutfen Tc Kimlik numarasını dogru girdiginizden emin olunuz !");
            }


        }
    }
}
