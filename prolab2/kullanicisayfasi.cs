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
    public partial class kullanicisayfasi : Form
    {
        List<Company> companies;
        public kullanicisayfasi(List<Company> cmp)
        {
            InitializeComponent();
            companies = cmp;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboDoldur();



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // DateTimePicker'dan seçilen tarihi alın
            DateTime selectedDate = dateTimePicker1.Value;

            // Eğer seçilen tarih 4 Aralık 2023 tarihinden küçükse veya 10 Aralık 2023 tarihinden büyükse
            if (selectedDate < new DateTime(2023, 12, 4) || selectedDate > new DateTime(2023, 12, 10))
            {
                // Kullanıcıya bir uyarı verin
                MessageBox.Show("Lütfen 4-10 Aralık 2023 tarihleri arasında bir tarih seçiniz.");

                // DateTimePicker'ı başlangıç tarihine ayarlayın
                dateTimePicker1.Value = new DateTime(2023, 12, 4);
            }
            else
            {
                // Seçilen tarih uygunsa, istediğiniz işlemleri yapabilirsiniz.
                // Örneğin, bu tarihle bir işlem başlatabilir veya gösterim güncelleyebilirsiniz.
                // Örneğin: listBox1.Items.Clear(); // listBox'ı temizleme
                //          listBox1.Items.Add(selectedDate.ToShortDateString()); // Seçilen tarihi listBox'a ekleme
            }
        }

        private void kullanicisayfasi_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private bool progChange=false;
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(progChange)
            {
                progChange = false;
                return;
            }
            ComboDoldur();
            comboBox2.Items.RemoveAt(comboBox3.SelectedIndex);
        }

        private void ComboDoldur()
        {
            int selectedIndex = comboBox1.SelectedIndex;
            int selected2 = comboBox3.SelectedIndex;
            if(selectedIndex >= 0)
            {
                if (selectedIndex == 0) // Eğer "Otobüs" seçeneği ilk sırada ise
                {
                    // Otobüs kalkış noktalarını ComboBox'a ekleyin
                    comboBox3.Items.Clear(); // ComboBox'ı temizle
                    comboBox3.Items.Add("İstanbul");
                    comboBox3.Items.Add("Kocaeli");
                    comboBox3.Items.Add("Ankara");
                    comboBox3.Items.Add("Eskişehir");
                    comboBox3.Items.Add("Konya");

                    comboBox2.Items.Clear(); // ComboBox'ı temizle
                    comboBox2.Items.Add("İstanbul");
                    comboBox2.Items.Add("Kocaeli");
                    comboBox2.Items.Add("Ankara");
                    comboBox2.Items.Add("Eskişehir");
                    comboBox2.Items.Add("Konya");
                }
                else if (selectedIndex == 1)
                {
                    comboBox3.Items.Clear(); // ComboBox'ı temizle
                    comboBox3.Items.Add("İstanbul");
                    comboBox3.Items.Add("Kocaeli");
                    comboBox3.Items.Add("Bilecik");
                    comboBox3.Items.Add("Ankara");
                    comboBox3.Items.Add("Eskişehir");
                    comboBox3.Items.Add("Konya");

                    comboBox2.Items.Clear(); // ComboBox'ı temizle
                    comboBox2.Items.Add("İstanbul");
                    comboBox2.Items.Add("Kocaeli");
                    comboBox2.Items.Add("Bilecik");
                    comboBox2.Items.Add("Ankara");
                    comboBox2.Items.Add("Eskişehir");
                    comboBox2.Items.Add("Konya");


                }

                // "ucak" seçili ise
                else if (selectedIndex == 2)
                {
                    comboBox3.Items.Clear(); // ComboBox'ı temizle
                    comboBox3.Items.Add("İstanbul");
                    comboBox3.Items.Add("Ankara");
                    comboBox3.Items.Add("Konya");

                    comboBox2.Items.Clear(); // ComboBox'ı temizle
                    comboBox2.Items.Add("İstanbul");
                    comboBox2.Items.Add("Ankara");
                    comboBox2.Items.Add("Konya");
                }
                if(selected2 >=0)
                {
                    progChange = true;
                    comboBox3.SelectedIndex = selected2;

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtacilansefer.Rows.Clear();
            foreach (var company in companies)
            {
                foreach (var trip in company.TripList)
                {
                    trip.Vehicle.BosKoltukHesapla();
                    if(trip.Vehicle.BosKoltukSayisi>= numericUpDown1.Value)
                    {
                        if(trip.DepartureTime.ToString("dd/MM/yyyy") == dateTimePicker1.Value.ToString("dd/MM/yyyy"))
                        {
                            if(comboBox1.SelectedItem.ToString() == trip.Vehicle.GetType().Name)
                            {
                                foreach (var route in trip.RouteList)
                                {
                                    if(comboBox3.SelectedItem.ToString()==route.DepartureLocation && comboBox2.SelectedItem.ToString()== route.ArrivalLocation)
                                    {
                                        DataGridViewRow row = new DataGridViewRow();
                                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = company.CompanyName});
                                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = "" });
                                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = trip.Vehicle.BosKoltukSayisi });
                                        row.Cells.Add(new DataGridViewTextBoxCell() { Value = trip.Vehicle.id });
                                        dtacilansefer.Rows.Add(row);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void kullanicisayfasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.LoginPanel.Visible = true;
        }

        DataGridViewRow seciliRow;
        private void dtacilansefer_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = dtacilansefer.Rows[e.RowIndex];
            seciliRow = row;
            var arac = companies.Find(x => x.CompanyName == row.Cells[0].Value.ToString()).Vehicles.Find(x => x.id == row.Cells[3].Value.ToString());
            BiletSecim biletSecim = new BiletSecim((int)numericUpDown1.Value,arac);
            biletSecim.FormClosed += Biletsecim_closing;


            biletSecim.Show();
        }

        private void Biletsecim_closing(object sender, FormClosedEventArgs e)
        {
            var arac = companies.Find(x => x.CompanyName == seciliRow.Cells[0].Value.ToString()).Vehicles.Find(x => x.id == seciliRow.Cells[3].Value.ToString());
            seciliRow.Cells[2].Value= arac.BosKoltukSayisi.ToString();
        }
    }
}
