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
    public partial class ogrenciDuzenle : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();
        public ogrenciDuzenle()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var ogrenci = vt.ogrenci.Where(s => s.tckNo == tcknoLbl.Text).FirstOrDefault();

            if (ogrenci != null)
            {
                ogrenci.okul = okulTxt.Text;
                ogrenci.bolum = bolumTxt.Text;
                ogrenci.adresi = adresRtxt.Text;
                ogrenci.sinif = sinifcb.SelectedIndex + 1;
                ogrenci.telefon = telefonTxt.Text;
                ogrenci.veliTelefon = veliTelefonuTxt.Text;
                ogrenci.fotograf = pictureBox1.ImageLocation;
                vt.SaveChanges();

                MessageBox.Show("Duzenleme Basarili");
                
            }

            else
            {
                MessageBox.Show("Hata");
            }
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = Environment.CurrentDirectory + "\\images";
            op.ShowDialog();

            pictureBox1.ImageLocation = Environment.CurrentDirectory + "\\images\\" + op.SafeFileName;
            pictureBox1.Refresh();

        }
    }
}
