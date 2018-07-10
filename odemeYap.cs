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
    public partial class odemeYap : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();
        public odemeYap()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var odemeBilgisi = vt.odemeler.Where(s => s.tckNo == metroTextBox1.Text).FirstOrDefault();
            var ogrenci = vt.ogrenci.Where(s => s.tckNo == metroTextBox1.Text).FirstOrDefault();

            if (ogrenci != null)
            {
                odemeEkrani oe = new odemeEkrani();
                oe.adilbl.Text = ogrenci.adi+" "+ogrenci.soyadi;
                oe.tcknolbl.Text = ogrenci.tckNo;
                oe.kalanTaksitlbl.Text = (odemeBilgisi.kalanTaksit - 1).ToString();
                oe.kalantoplamlbl.Text = ((odemeBilgisi.kalanTaksit - 1) * 800).ToString();
                oe.ShowDialog();


            }

            else
            {

                MessageBox.Show("Lutfen gecerli bir kimlik numarası giriniz !");

            }
            


        }
    }
}
