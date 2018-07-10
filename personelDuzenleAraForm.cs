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
    public partial class personelDuzenleAraForm : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();
        public personelDuzenleAraForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var personel = vt.personel.Where(s => s.adi == metroTextBox2.Text || s.soyadi == metroTextBox2.Text || s.tckNo == metroTextBox1.Text).FirstOrDefault();

            if (personel != null)
            {
                personelDuzenle tb = new personelDuzenle();
                tb.adilbl.Text = personel.adi + "  " + personel.soyadi;
                tb.telefontxt.Text = personel.telefon;
                tb.tcknolbl.Text = personel.tckNo;         
                tb.maasitxt.Text = personel.maas.ToString();


                tb.ShowDialog();



            }

            else
            {

                MessageBox.Show("Personel Bulunamadı !");
            }
        }
    }
}
