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
    public partial class YolcuBilgiFormu : Form
    {
        private Dictionary<int,Customer> customers = new Dictionary<int,Customer>();
        List<Button> yolcuButons = new List<Button>();
        public bool Odeme = false;
        int tiklananIndex = -1;
        public YolcuBilgiFormu(int yolcuSayisi)
        {
            InitializeComponent();
            customers = new Dictionary<int,Customer>();
            for (int i = 0; i < yolcuSayisi; i++)
            {
                Button button = new Button()
                {
                    Name = $"Yolcu_{i + 1}",
                    Text = $"Yolcu_{i + 1}",
                    Size = new Size(80, 30),
                    Location = new Point(300,60 + (i*35))
                };
                button.Click += Buton_Click;
                yolcuButons.Add(button);
                this.Controls.Add(button);
            }
        }

        private void Buton_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            yolcuButons.ForEach(button =>
            {
                if (button != tiklanan)
                {
                    button.BackColor = Color.Beige;
                }
                else
                {
                    button.BackColor = Color.LightPink;
                }
            });
            Gorunur();
            tiklananIndex = yolcuButons.IndexOf(tiklanan);
            if (!customers.ContainsKey(tiklananIndex))
            {
                customers.Add(tiklananIndex, new Customer());
                Temizle();
            }
            else
            {
                textBox1.Text = customers[tiklananIndex].Ad;
                textBox2.Text = customers[tiklananIndex].Soyad;
                textBox3.Text = customers[tiklananIndex].TC;
                dateTimePicker1.Value = customers[tiklananIndex].BornTime;
            }
        }

        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.ResetText();
        }
        private void Gorunur()
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            dateTimePicker1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            customers[tiklananIndex].Ad = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            customers[tiklananIndex].Soyad = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            customers[tiklananIndex].TC = textBox3.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            customers[tiklananIndex].BornTime = dateTimePicker1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Odeme = true;
            this.Close();
        }
    }
}
