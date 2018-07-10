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
    public partial class goruntule : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();

        public goruntule()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroLabel2.Visible = false;
            var sonuc = vt.ogrenci.Where(s => s.tckNo == metroTextBox1.Text.ToString()).FirstOrDefault();

            if (sonuc == null)
            {
                metroLabel2.Visible = true;
            }

            else
            {

                ogrenciGoruntule og = new ogrenciGoruntule();
                og.ogrIsimlbl.Text = sonuc.adi.ToString();
                og.ogrTcklbl.Text = sonuc.tckNo.ToString();
                og.pictureBox1.ImageLocation = sonuc.fotograf;
                og.ogrOdalbl.Text = sonuc.kalacagiOda.ToString();
                og.ogrTellbl.Text = sonuc.telefon.ToString();
                og.richTextBox1.Text = sonuc.adresi.ToString();
                og.ShowDialog();
                this.Close();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var ogrenci = vt.ogrenci.ToList();
            tumOgrenciler tu = new tumOgrenciler();
            tu.dataGridView1.DataSource = ogrenci;
            tu.ShowDialog();

        }
    }
}
