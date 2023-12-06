using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace prolab2
{

    public partial class CompanyPanel : UserControl
    {
        public Login login;
        public Company Company { get; set; } = null;
        public CompanyPanel()
        {
            InitializeComponent();

            comboBox1.Items.Add("Train");
            comboBox1.Items.Add("Airplane");
            comboBox1.Items.Add("Bus");
            
        }

        private void vehicleAddButton_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text == "Bus")
            {
                Bus bus = new Bus();
                bus.Model=txtmodel.Text;
                bus.id=txtid.Text;
                bus.fuelType=txtyakit.Text;
                bus.Capacity= int.Parse(txtkapasite.Text);
                Company.Vehicles.Add(bus);

            }
            if(comboBox1.Text == "Train")
            {
                Train train = new Train();
                train.Model=txtmodel.Text;
               train.id = txtid.Text;
                train.fuelType = txtyakit.Text;
                train.Capacity  = int.Parse(txtkapasite.Text); 
                Company.Vehicles.Add(train);

            }
            if (comboBox1.Text == "Airplane")
            {
                Airplane plane = new Airplane();
                plane.Model = txtmodel.Text;
                plane.id = txtid.Text;
                plane.fuelType = txtyakit.Text;
                plane.Capacity = int.Parse(txtkapasite.Text);
                Company.Vehicles.Add(plane);

            }
            listboxUpdate();
            txtmodel.Text = "";
            txtkapasite.Text = "";
            comboBox1.Text = "";
        }

        private void çıkışButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.LoginPanel.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgarac.SelectedRows.Count > 0)
            {
                // Seçilen satırın indeksini al
                int selectedRowIndex = dgarac.SelectedRows[0].Index;

                // Eğer seçilen satırın indeksi, vehicles listesinin indeks sınırları içindeyse devam et
                if (selectedRowIndex >= 0 && selectedRowIndex < Company.Vehicles.Count)
                {
                    // Seçilen aracı çıkar
                    Vehicle selectedVehicle = Company.Vehicles[selectedRowIndex];
                    Company.Vehicles.Remove(selectedVehicle);

                    // İlgili işlemleri gerçekleştirme (örneğin, güncellenmiş listeyi DataGridView'a yansıtma)
                    AraclariYukle();
                }
            }
        }


        void listboxUpdate()
        {
            DataGridViewRow newRow = new DataGridViewRow();
            DataGridViewTextBoxCell cell0 = new DataGridViewTextBoxCell();
            cell0.Value = comboBox1.SelectedItem; // İlk sütun değeri
            newRow.Cells.Add(cell0);
            // Yeni hücreleri oluşturun ve değerlerini ayarlayın
            DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
            cell1.Value = txtid.Text; // İlk sütun değeri
            newRow.Cells.Add(cell1);

            DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
            cell2.Value = txtmodel.Text; // İkinci sütun değeri
            newRow.Cells.Add(cell2);
            DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
            cell3.Value = txtkapasite.Text; // İkinci sütun değeri
            newRow.Cells.Add(cell3);
            DataGridViewTextBoxCell cell4 = new DataGridViewTextBoxCell();
            cell4.Value = txtyakit.Text; // İkinci sütun değeri
            newRow.Cells.Add(cell4);

            // DataGridView'a yeni satır ekleyin
            dgarac.Rows.Add(newRow);

            //listBox3.Items.Clear();

            //listBox1.Items.Clear();
            //foreach (Vehicle vehicle in Company.Vehicles)
            //{
            //    listBox1.Items.Add(vehicle.Capacity + " - " + vehicle.Model + " - " + vehicle.GetType().ToString().Split('.')[1]);
            //}

        }

        private void CompanyPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void seferEkle_Click(object sender, EventArgs e)
        {
            var vehicleTur = dgarac.SelectedRows[0].Cells[0].Value.ToString();
            int index = lvGuzergah.SelectedItems[0].Index;
            List<string> tempGuz= new List<string>();
            switch (vehicleTur)
            {
                case "Bus":
                    if(index == 0)
                    {
                        tempGuz = Data.guzergah3;
                    }
                    else
                    {
                        tempGuz = Data.guzergah4;
                    }
                    break;
                case "Train":
                    if (index == 0)
                    {
                        tempGuz = Data.guzergah1;
                    }
                    else
                    {
                        tempGuz = Data.guzergah2;
                    }
                    break;
                case "Plane":
                    if (index == 0)
                    {
                        tempGuz = Data.guzergah5;
                    }
                    else
                    {
                        tempGuz = Data.guzergah6;
                    }
                    break;
                default:
                    break;
            }
            //string selectedRoute = lvGuzergah.SelectedItems[0].Text;
            //int length = selectedRoute.Length - selectedRoute.IndexOf(':') - 1;
            //int index = selectedRoute.IndexOf(':') + 1;
            //selectedRoute = selectedRoute.Substring(index, length);
            //string[] routeParts = selectedRoute.Split('-');
            //if (routeParts.Length > 0)
            //{
                Trip temp = new Trip(tempGuz);
                temp.Vehicle = Company.Vehicles[dgarac.SelectedRows[0].Index];
                temp.DepartureTime = dtTarih.Value;
                Company.TripList.Add(temp);

            //}
            AcilanSeferGuncelle();
        }
        void AcilanSeferGuncelle()
        {
            if(Company!= null)
            {
                dgAcilanSeferler.Rows.Clear();
                foreach (var trip in Company.TripList)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = trip.DepartureTime });
                    string routeList = string.Empty;
                    for (int i = 0; i < trip.RouteList.Count; i++)
                    {
                        if (i == 0)
                        {
                            routeList += $"{trip.RouteList[i].DepartureLocation} - {trip.RouteList[i].ArrivalLocation}";
                        }
                        else if (i > 0)
                        {
                            routeList += $" - {trip.RouteList[i].ArrivalLocation}";
                        }

                    }
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = routeList });
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = trip.Vehicle.id });
                    dgAcilanSeferler.Rows.Add(row);
                }

            }
            //listBox3.Items.Clear();
            //int count = Company.Vehicles[listBox1.SelectedIndex].trip.RouteList.Count;
            //string fullTrip = "";
            //int x = 0;
            //for(int i = 0; i< count;i++)
            //{
            //    if (i == 0)
            //    {
            //        fullTrip += $"{Company.Vehicles[listBox1.SelectedIndex].trip.RouteList[i].DepartureLocation} - {Company.Vehicles[listBox1.SelectedIndex].trip.RouteList[i].ArrivalLocation}";
            //    }
            //    else if (i > 0)
            //    {
            //        fullTrip += $" - {Company.Vehicles[listBox1.SelectedIndex].trip.RouteList[i].ArrivalLocation}";
            //    }
                
            //}
           // listBox3.Items.Add(fullTrip);
        }

        private void seferSil_Click(object sender, EventArgs e)
        {
            if (dgAcilanSeferler.SelectedRows.Count > 0)
            {
                Company.TripList.RemoveAt(dgAcilanSeferler.SelectedRows[0].Index);
                dgAcilanSeferler.Rows.RemoveAt(dgAcilanSeferler.SelectedRows[0].Index);
            }
           //Company.Vehicles[dataGridView2.SelectedRows[]].trip.RouteList.Clear();
            
           //dataGridView2.Rows.Clear();
        }

      
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            lvGuzergah.Items.Clear();
            if(dgarac.SelectedRows.Count > 0)
            {
                if (dgarac.SelectedRows[0].Cells[0].Value.ToString().Contains("Bus"))
                {
                    string guzergah = string.Empty;
                    foreach (var sehir in Data.guzergah3)
                    {
                        guzergah += sehir.ToString() + "-";
                    }
                    lvGuzergah.Items.Add(guzergah);
                    guzergah = string.Empty;
                    foreach (var sehir in Data.guzergah4)
                    {
                        guzergah += sehir.ToString() + "-";
                    }
                    lvGuzergah.Items.Add(guzergah);
                }
                if (dgarac.SelectedRows[0].Cells[0].Value.ToString().Contains("Train"))
                {
                    string guzergah = string.Empty;
                    foreach (var sehir in Data.guzergah1)
                    {
                        guzergah += sehir.ToString() + "-";
                    }
                    lvGuzergah.Items.Add(guzergah);
                    guzergah = string.Empty;
                    foreach (var sehir in Data.guzergah2)
                    {
                        guzergah += sehir.ToString() + "-";
                    }
                    lvGuzergah.Items.Add(guzergah);
                }
                if (dgarac.SelectedRows[0].Cells[0].Value.ToString().Contains("Airplane"))
                {
                    string guzergah = string.Empty;
                    foreach (var sehir in Data.guzergah5)
                    {
                        guzergah += sehir.ToString() + "-";
                    }
                    lvGuzergah.Items.Add(guzergah);
                    guzergah = string.Empty;
                    foreach (var sehir in Data.guzergah6)
                    {
                        guzergah += sehir.ToString() + "-";
                    }
                    lvGuzergah.Items.Add(guzergah);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AraclariYukle()
        {
            if(Company != null)
            {
                dgarac.Rows.Clear();
                foreach (var vehicle in Company.Vehicles)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    DataGridViewTextBoxCell cell0 = new DataGridViewTextBoxCell();
                    cell0.Value = vehicle.GetType().Name.ToString(); // İlk sütun değeri
                    newRow.Cells.Add(cell0);
                    // Yeni hücreleri oluşturun ve değerlerini ayarlayın
                    DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                    cell1.Value = vehicle.id; // İlk sütun değeri
                    newRow.Cells.Add(cell1);

                    DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                    cell2.Value = vehicle.Model; // İkinci sütun değeri
                    newRow.Cells.Add(cell2);
                    DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                    cell3.Value = vehicle.Capacity; // İkinci sütun değeri
                    newRow.Cells.Add(cell3);
                    DataGridViewTextBoxCell cell4 = new DataGridViewTextBoxCell();
                    cell4.Value = vehicle.fuelType; // İkinci sütun değeri
                    newRow.Cells.Add(cell4);

                    // DataGridView'a yeni satır ekleyin
                    dgarac.Rows.Add(newRow);
                }
            }
            /**/
        }
        private void CompanyPanel_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {

                AraclariYukle();
                AcilanSeferGuncelle();
            }
        }

        private void dgAcilanSeferler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
