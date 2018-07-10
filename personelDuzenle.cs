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
    public partial class personelDuzenle : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();
        public personelDuzenle()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var personel = vt.personel.Where(s => s.tckNo == tcknolbl.Text).FirstOrDefault();

            personel.telefon = telefontxt.Text;
            personel.maas = double.Parse(maasitxt.Text);
            personel.adres = adresrtxt.Text;
            personel.gorevi = gorevcmb.SelectedItem.ToString();

            vt.SaveChanges();

            MessageBox.Show("Duzenleme Basarili");

        }
    }
}
