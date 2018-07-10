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
    public partial class personelSil : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();

        public personelSil()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            var personel = vt.personel.Where(s => s.adi == metroTextBox2.Text || s.soyadi == metroTextBox2.Text || s.tckNo == metroTextBox1.Text).FirstOrDefault();

            if (personel != null)
            {
                aditxt.Text = personel.adi;
                soyaditxt.Text = personel.soyadi;
                tcknotxt.Text = personel.tckNo;
                gorevitxt.Text = personel.gorevi;
                pictureBox1.ImageLocation = personel.fotograf;

                panel1.Visible = true;


            }

            else
            {

                MessageBox.Show("Personel Bulunamadı !");
            }



        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var personel = vt.personel.Where(s => s.tckNo == tcknotxt.Text).FirstOrDefault();

            vt.personel.Remove(personel);
            vt.SaveChanges();

            MessageBox.Show("Silme islemi basarili");

        }

        private void personelSil_Load(object sender, EventArgs e)
        {

        }
    }
}
