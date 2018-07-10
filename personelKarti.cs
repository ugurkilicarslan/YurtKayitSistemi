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
    public partial class personelKarti : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();

        public personelKarti()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            float maas = float.Parse(maasitxt.Text.ToString());



            personel pe = new personel();
            pe.adi = metroTextBox1.Text.ToString();
            pe.soyadi = soyaditxt.Text;
            pe.tckNo = tcknotxt.Text;
            pe.adres = adresrtxt.Text;
            pe.kanGrubu = kanGrubucmb.SelectedItem.ToString();
            pe.gorevi = gorevcmb.SelectedItem.ToString();
            pe.maas = maas;

            //pe.fotograf = Environment.CurrentDirectory + "headless.jpg";
            vt.personel.Add(pe);
            vt.SaveChanges();


        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = Environment.CurrentDirectory + "\\images";
            op.ShowDialog();

            pictureBox1.ImageLocation = Environment.CurrentDirectory + "\\images\\" + op.SafeFileName;
            pictureBox1.Refresh();
        }
    }
}
