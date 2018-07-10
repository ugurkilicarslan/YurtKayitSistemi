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
    public partial class silOgrenciGoruntule : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();
        public silOgrenciGoruntule()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var ogrenci = vt.ogrenci.Where(s => s.tckNo == ogrTcklbl.Text).FirstOrDefault();

            vt.ogrenci.Remove(ogrenci);
            vt.SaveChanges();

            MessageBox.Show("Silme islemi basarili");

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
        
            this.Close();
        }
    }
}
