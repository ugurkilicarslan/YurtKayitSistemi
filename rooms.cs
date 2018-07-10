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
    public partial class rooms : MetroFramework.Forms.MetroForm
    {
        Boolean a = true;
        veritabanı vt = new veritabanı();
       public int odaAdi;
        List<string> veriler = new List<string>();
        List<string> fotograflar = new List<string>();
        public rooms()
        {
            InitializeComponent();
        }

        private void kat1_Click(object sender, EventArgs e)
        {
            kat1.BackColor = Color.Tan;
            kat2.BackColor = Color.IndianRed;
            kat3.BackColor = Color.IndianRed;
            kat4.BackColor = Color.IndianRed;
            kat5.BackColor = Color.IndianRed;


            pnl.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void kat2_Click(object sender, EventArgs e)
        {
            kat1.BackColor = Color.IndianRed;
            kat2.BackColor = Color.Tan;
            kat3.BackColor = Color.IndianRed;
            kat4.BackColor = Color.IndianRed;
            kat5.BackColor = Color.IndianRed;


            pnl.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void kat3_Click(object sender, EventArgs e)
        {
            kat1.BackColor = Color.IndianRed;
            kat2.BackColor = Color.IndianRed;
            kat3.BackColor = Color.Tan;
            kat4.BackColor = Color.IndianRed;
            kat5.BackColor = Color.IndianRed;

            pnl.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void kat4_Click(object sender, EventArgs e)
        {
            kat1.BackColor = Color.IndianRed;
            kat2.BackColor = Color.IndianRed;
            kat3.BackColor = Color.IndianRed;
            kat4.BackColor = Color.Tan;
            kat5.BackColor = Color.IndianRed;


            pnl.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
        }

        private void kat5_Click(object sender, EventArgs e)
        {
            kat1.BackColor = Color.IndianRed;
            kat2.BackColor = Color.IndianRed;
            kat3.BackColor = Color.IndianRed;
            kat4.BackColor = Color.IndianRed;
            kat5.BackColor = Color.Tan;


            pnl.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void rooms_Load(object sender, EventArgs e)
        {
            /* odaların doluluk durumuna gore butonların rengi belirleniyor */

            foreach (FlowLayoutPanel item in this.Controls.OfType<FlowLayoutPanel>())
            {
                if (item == flowLayoutPanel1)
                {
                    continue;
                }
                    foreach (Button i in item.Controls)
                {
                    int oda = Int32.Parse(i.Text);
                    var doluluk = vt.odalar.Where(s => s.kodu ==oda && s.ogrenciTckNo != null).ToList();

                 
                    if (doluluk.Count <= 2)
                    {
                        i.BackColor = Color.GreenYellow;
                    }
                    if (doluluk.Count == 3)
                    {
                        i.BackColor = Color.Yellow;
                    }
                    if (doluluk.Count == 4)
                    {
                        i.BackColor = Color.Red;
                    }
                   
                }
               
            }

        }
        public void deneme(object x, EventArgs e)
        {
            
            /*Tıklanan butonun bilgisini donduruyor */
            Button bu = x as Button;

            int odaKodu = Int32.Parse(bu.Text);

          

            if (bu.BackColor == Color.Red)
            {
                MessageBox.Show("Bu oda tamamen doludur !");
                
               
            }
            else
            {
                odaAdi = Int32.Parse(bu.Text);
                
            }

            /* Odada kalan ogrencilerin goruntulenmesi icin aşağıda sorgu yapılıyor */

            var ogrenciler = vt.ogrenci.Where(s => s.kalacagiOda == odaKodu).ToList();
            odadakiOgrenciler oo = new odadakiOgrenciler();
            foreach (var item in ogrenciler)
            {
                veriler.Add(item.adi + " " + item.soyadi);
                fotograflar.Add(item.fotograf);

            }


           
            if (ogrenciler.Count == 1)
            {
               
                    oo.pictureBox1.ImageLocation = fotograflar[0];
                    oo.metroLabel1.Text = veriler[0];
                    oo.ShowDialog();
                

            }
            if (ogrenciler.Count == 2)
            {
                oo.pictureBox1.ImageLocation = fotograflar[0];
                oo.metroLabel1.Text = veriler[0];
                oo.pictureBox2.ImageLocation = fotograflar[1];
                oo.metroLabel2.Text = veriler[1];
                oo.ShowDialog();
                


            }
            if (ogrenciler.Count == 3)
            {
                oo.pictureBox1.ImageLocation = fotograflar[0];
                oo.metroLabel1.Text = veriler[0];
                oo.pictureBox2.ImageLocation = fotograflar[1];
                oo.metroLabel2.Text = veriler[1];
                oo.pictureBox3.ImageLocation = fotograflar[2];
                oo.metroLabel3.Text = veriler[2];
                oo.ShowDialog();

            }
            if (ogrenciler.Count == 4)
            {
                oo.pictureBox1.ImageLocation = fotograflar[0];
                oo.metroLabel1.Text = veriler[0];
                oo.pictureBox2.ImageLocation = fotograflar[1];
                oo.metroLabel2.Text = veriler[1];
                oo.pictureBox3.ImageLocation = fotograflar[2];
                oo.metroLabel3.Text = veriler[2];
                oo.pictureBox4.ImageLocation = fotograflar[3];
                oo.metroLabel4.Text = veriler[3];
                oo.ShowDialog();
            }

            




        }

        private void rooms_MouseEnter(object sender, EventArgs e)
        {
          
            /* Fare ekrana girdiğinde ekrandaki tüm kontrolleri tarıyor(buton,label vs) */
            foreach (FlowLayoutPanel item in this.Controls.OfType<FlowLayoutPanel>())
            {
                if (a)
                {
                    foreach (Button i in item.Controls)
                    {
                        i.Click += new EventHandler(deneme);


                    }
                    a = false;
                    break;
                }
               
                
            }

        }

        private void button65_Click(object sender, EventArgs e)
        {
          
        }
    }
}
