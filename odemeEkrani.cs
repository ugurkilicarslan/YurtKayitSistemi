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
    public partial class odemeEkrani : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();
        public odemeEkrani()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            var odemeKaydet = vt.odemeler.Where(s => s.tckNo == tcknolbl.Text).FirstOrDefault();

            odemeKaydet.kalanTaksit = Int32.Parse(kalanTaksitlbl.Text);
            odemeKaydet.vade = Int32.Parse(kalanTaksitlbl.Text);

            vt.SaveChanges();

            MessageBox.Show("Odeme Alındı!");

            this.Close();


        }
    }
}
