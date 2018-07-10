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
    public partial class kayitSilAraForm : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();
        public kayitSilAraForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


            var ogrenci = vt.ogrenci.Where(s => s.tckNo == metroTextBox1.Text).FirstOrDefault();

            if (ogrenci != null)
            {
                silOgrenciGoruntule sg = new silOgrenciGoruntule();

                sg.ogrIsimlbl.Text = ogrenci.adi + "  " + ogrenci.soyadi;
                sg.ogrTcklbl.Text = ogrenci.tckNo;
                sg.ogrOdalbl.Text = ogrenci.kalacagiOda.ToString();
                sg.ogrTellbl.Text = ogrenci.telefon;
                sg.richTextBox1.Text = ogrenci.adresi;
                
                sg.ShowDialog();
                
            

            }
            else
            {
                MessageBox.Show("Lutfen gecerli bir kimlik numarası giriniz !");
            }
        }
    }
}
