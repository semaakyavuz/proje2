using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prolab2
{
    public partial class BiletSecim : Form
    {
        int secimSayisi;
        Vehicle arac;
        List<Button> koltuklar;
        List<Button> seciliIndex;
        public BiletSecim(int secimSayisi,Vehicle vehicle)
        {
            InitializeComponent();
            this.secimSayisi = secimSayisi;
            seciliIndex = new List<Button>();
            arac = vehicle;
            koltuklar = new List<Button>();
            int satirSayisi = arac.Capacity / 5;
            int sutunSayisi = arac.Capacity / satirSayisi;
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    Button buton = new Button();
                    buton.Name = $"Koltuk_{i+1}_{j+1}";
                    buton.Text = $"Koltuk-{koltuklar.Count+1}";
                    buton.Size = new Size(60, 60);
                    buton.Location = new Point(20 + j * 70, 20 + i * 70);
                    buton.Click += Buton_Click;
                    if(arac.DoluKoltukIndexes.Contains(koltuklar.Count))
                    {
                        buton.BackColor = Color.DarkRed;
                        buton.Enabled = false;
                    }
                    else if (arac.RezerveKoltukIndexes.Contains(koltuklar.Count))
                    {
                        buton.BackColor = Color.Navy;
                        buton.Enabled = false;  
                    }
                    else
                    {
                        buton.BackColor = Color.Beige;
                    }
                    koltuklar.Add( buton );
                    this.Controls.Add( buton );
                }
            }
        }

        private void Buton_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            int secilenKoltukSayisi = 0;
            foreach (var koltuk in koltuklar)
            {
                if(koltuk.BackColor == Color.Green)
                {
                    secilenKoltukSayisi++;
                }
            }
            if (tiklanan.BackColor == Color.Green) 
            {
                tiklanan.BackColor = Color.Beige;
                seciliIndex.Remove(tiklanan);
            }
            else if(secilenKoltukSayisi < secimSayisi)
            {
                tiklanan.BackColor = tiklanan.BackColor == Color.Beige ? Color.Green : Color.Beige;
                seciliIndex.Add(tiklanan);
            }
            else
            {
                MessageBox.Show($"en fazla {secimSayisi} kadar koltuk seçebilirsiniz");
            }
        }

        private void btnRezerve_Click(object sender, EventArgs e)
        {
            foreach (var koltuk in koltuklar)
            {
                if (koltuk.BackColor == Color.Green)
                {
                    arac.KoltukRezerve(koltuklar.IndexOf(koltuk));
                    koltuk.BackColor = Color.Navy;
                }
            }
            YolcuBilgiFormu yolcuBilgi = new YolcuBilgiFormu(secimSayisi);
            yolcuBilgi.FormClosing += Yolcu_Closing; 
            yolcuBilgi.Show();
        }

        private void Yolcu_Closing(object sender, FormClosingEventArgs e)
        {
            if (((YolcuBilgiFormu)sender).Odeme)
            {
                foreach (var koltuk in koltuklar)
                {
                    if(seciliIndex.Contains(koltuk))
                    {
                        arac.KoltukRezerveKaldir(koltuklar.IndexOf(koltuk));
                        arac.KoltukDoldur(koltuklar.IndexOf(koltuk));
                        koltuk.BackColor = Color.DarkRed;
                    }
                }
            }
            this.Close();
        }
    }
}
