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
    public partial class personelGoruntuleAraForm : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();

        public personelGoruntuleAraForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            var personel = vt.personel.Where(s => s.adi == metroTextBox2.Text || s.soyadi == metroTextBox2.Text || s.tckNo == metroTextBox1.Text).FirstOrDefault();

            if (personel != null)
            {
                tekPersonelGoruntule tb = new tekPersonelGoruntule();
                tb.aditxt.Text = personel.adi + "  " + personel.soyadi;
                tb.telefontxt.Text = personel.telefon;
                tb.tckNotxt.Text = personel.tckNo;
                tb.gorevitxt.Text = personel.gorevi;
                tb.maasitxt.Text = personel.maas.ToString();

                tb.ShowDialog();



            }

            else
            {

                MessageBox.Show("Personel Bulunamadı !");
            }

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var personeller = vt.personel.ToList();
            tumPersoneller tp = new tumPersoneller();
            tp.dataGridView1.DataSource = personeller;
            tp.ShowDialog();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
