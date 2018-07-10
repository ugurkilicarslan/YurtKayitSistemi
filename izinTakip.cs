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
    public partial class izinTakip : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();
        public izinTakip()
        {
            InitializeComponent();
        }

        private void izinTakip_Load(object sender, EventArgs e)
        {
            var izinler = vt.izin.Where(s => s.donusTarihi < DateTime.Now).ToList();
            int i = 40,j=80;
            foreach (var item in izinler)
            {

                var ogrenci = vt.ogrenci.Where(s => s.tckNo == item.tckNo).FirstOrDefault();
                Label adi= new Label();
                Label soyadi = new Label();
                Label gidisTarihi = new Label();
                Label donusTarihi = new Label();
                Label telefon = new Label();
                RichTextBox adres = new RichTextBox();

                adi.Text = ogrenci.adi.ToUpper();
                soyadi.Text = ogrenci.soyadi.ToUpper();
                gidisTarihi.Text = item.gidisTarihi.ToString();
                donusTarihi.Text = item.donusTarihi.ToString();
                telefon.Text = ogrenci.telefon.ToString();
                adres.Text = item.gidecegiAdres.ToUpper();


                adi.Location = new Point(0+i, j);
                soyadi.Location = new Point(40+i, j);
                gidisTarihi.Location = new Point(i+80, j);
                donusTarihi.Location = new Point(i+120, j);
                telefon.Location = new Point(i+160, j);
                adres.Location = new Point(i+540, j);
                adres.Size = new Size(i+200, 60);

                panel1.Controls.Add(adi);
                panel1.Controls.Add(soyadi);
                panel1.Controls.Add(gidisTarihi);
                panel1.Controls.Add(donusTarihi);
                panel1.Controls.Add(telefon);
                panel1.Controls.Add(adres);

                j += 75;


            }

        }
    }
}
