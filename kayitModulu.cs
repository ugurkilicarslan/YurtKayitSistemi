using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarrenLee.Media;

namespace YurtOtomasyonu
{
    public partial class kayitModulu : MetroFramework.Forms.MetroForm
    {

        veritabanı vt = new veritabanı();
      

        public kayitModulu()
        {
            InitializeComponent();
         
        }

       

        private void metroButton1_Click(object sender, EventArgs e)
        {
            rooms rooms = new rooms();
          
            rooms.ShowDialog();
            odaKodutxt.Text = rooms.odaAdi.ToString();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            odemeler odemeler = new odemeler();

            odemeler.tckNo = tckTxt.Text;
            odemeler.kalanTaksit = (sozlesmeSuresicb.SelectedIndex + 1) * 6;
            odemeler.vade= (sozlesmeSuresicb.SelectedIndex + 1) * 6;
            odemeler.aylikTutar = 800;
            odemeler.odemeTarihi= dateTimePicker1.Value;
            vt.odemeler.Add(odemeler);

            int kod = Int32.Parse(odaKodutxt.Text);
            var oda = vt.odalar.Where(s => s.kodu == kod).FirstOrDefault();
            oda.ogrenciTckNo = tckTxt.Text;
            

            ogrenci ogrenci = new ogrenci();
            ogrenci.adi = adiTxt.Text.ToString();
            ogrenci.soyadi = soyadiTxt.Text.ToString();
            ogrenci.tckNo = tckTxt.Text.ToString();
            ogrenci.okul = okulTxt.Text.ToString();
            ogrenci.sinif = Int32.Parse(sinifcb.SelectedItem.ToString());
            ogrenci.bolum = bolumTxt.Text.ToString();
            ogrenci.sozlesmeSuresi = sozlesmeSuresicb.SelectedIndex;
            ogrenci.kalacagiOda = Int32.Parse( odaKodutxt.Text);
            ogrenci.kayitTarihi = dateTimePicker1.Value;
            ogrenci.telefon = telefonTxt.Text.ToString();
            ogrenci.veliAdi = veliAdiTxt.Text.ToString();
            ogrenci.veliTelefon = veliTelefonuTxt.Text.ToString();
            ogrenci.adresi = adresRtxt.Text.ToString();
            ogrenci.kanGrubu = kanGrubuCmb.SelectedItem.ToString();
            ogrenci.fotograf = pictureBox1.ImageLocation;


            vt.ogrenci.Add(ogrenci);
            vt.SaveChanges();

            MessageBox.Show("Kayıt Basarili");
            this.Close();
            


        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {


            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = Environment.CurrentDirectory + "\\images";
            op.ShowDialog();

            pictureBox1.ImageLocation = Environment.CurrentDirectory + "\\images\\"+op.SafeFileName;
            pictureBox1.Refresh();

        }

        private void sozlesmeSuresicb_SelectedIndexChanged(object sender, EventArgs e)
        {
            toplamUcretlbl.Text = (800 * (sozlesmeSuresicb.SelectedIndex + 1 * 6)).ToString()+"  ₺";
        }
    }
}
