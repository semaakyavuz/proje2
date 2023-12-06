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
    public partial class AdminPanel : UserControl
    {
        public Login login;

        public List<Company> companies = new List<Company>();

        int hizmetbedeli = 1000;
        public AdminPanel()
        {
            InitializeComponent();
            companies.Add(new Company()
            {
                CompanyName = "A Firması",
                Username = "A",
                Password = "A",
                Vehicles = new List<Vehicle>()
                    {
                        new Bus()
                        {
                            Capacity = 20,
                            fuelType = "Dizel",
                            id = "O1",
                            Model = "99",
                        },
                        new Bus()
                        {
                            Capacity = 15,
                            fuelType = "Dizel",
                            id = "O2",
                            Model = "99",
                        },
                    },
            });
            DateTime date = DateTime.Parse("04/12/2023");
            for (int i = 0; i < 7; i++)
            {
                foreach (var vehicle in companies[0].Vehicles)
                {
                    companies[0].TripList.Add(new Trip(Data.guzergah3)
                    {
                        DepartureTime = date.AddDays(i),
                        Vehicle = vehicle
                    });
                }
            }
            companies.Add(new Company()
            {
                CompanyName = "B Firması ",
                Username = "B",
                Password = "B",
                Vehicles = new List<Vehicle>()
                {
                    new Bus()
                    {
                        Capacity = 15,
                        fuelType = "Motorin",
                        id = "O2",
                        Model = "89",
                    },
                    new Bus()
                    {
                        Capacity = 20,
                        fuelType = "Motorin",
                        id = "O3",
                        Model = "79",
                    },
                },

            });
            date = DateTime.Parse("04/12/2023");
            for (int i = 0; i < 7; i++)
            {
                int a = 0;
                foreach (var vehicle in companies[1].Vehicles)
                {
                    if (a == 0)
                    {
                        companies[1].TripList.Add(new Trip(Data.guzergah3)
                        {
                            DepartureTime = date.AddDays(i),
                            Vehicle = vehicle
                        });
                    }
                    else
                    {
                        companies[1].TripList.Add(new Trip(Data.guzergah4)
                        {
                            DepartureTime = date.AddDays(i),
                            Vehicle = vehicle
                        });
                    }
                    a++;
                }
            }

            companies.Add(new Company()
            {
                CompanyName = "C Firması",
                Username = "C",
                Password = "C",
                Vehicles = new List<Vehicle>()
                {
                    new Bus()
                    {
                        Capacity = 20,
                        fuelType = "Motorin",
                        id = "05",
                        Model = "99",
                    },
                    new Airplane()
                    {
                        Capacity = 30,
                        fuelType = "Gaz",
                        id = "06",
                        Model = "129",
                    },
                    new Airplane()
                    {
                        Capacity = 30,
                        fuelType = "Gaz",
                        id = "07",
                        Model = "119",
                    },
                },

            });
            date = DateTime.Parse("04/12/2023");
            for (int i = 0; i < 7; i++)
            {
                int a = 0;
                foreach (var vehicle in companies[2].Vehicles)
                {
                    if (a == 0)
                    {
                        companies[2].TripList.Add(new Trip(Data.guzergah4)
                        {
                            DepartureTime = date.AddDays(i),
                            Vehicle = vehicle
                        });
                    }
                    else
                    {
                        companies[2].TripList.Add(new Trip(Data.guzergah5)
                        {
                            DepartureTime = date.AddDays(i),
                            Vehicle = vehicle
                        });
                    }
                }
            }

            companies.Add(new Company()
            {
                CompanyName = "D Firması",
                Username = "D",
                Password = "D",
                Vehicles = new List<Vehicle>()
                {
                    new Train()
                    {
                        Capacity = 25,
                        fuelType = "Elektrik",
                        id = "10",
                        Model = "789",
                    },
                    new Train()
                    {
                        Capacity = 25,
                        fuelType = "Elektrik",
                        id = "11",
                        Model = "779",
                    },
                    new Train()
                    {
                        Capacity = 25,
                        fuelType = "Elektrik",
                        id = "1",
                        Model = "769",
                    },
                },
            });
            date = DateTime.Parse("04/12/2023");
            for (int i = 0; i < 7; i++)
            {
                int a = 0;
                foreach (var vehicle in companies[3].Vehicles)
                {
                    if (a == 0)
                    {
                        companies[3].TripList.Add(new Trip(Data.guzergah1)
                        {
                            DepartureTime = date.AddDays(i),
                            Vehicle = vehicle
                        });
                    }
                    else
                    {
                        companies[2].TripList.Add(new Trip(Data.guzergah2)
                        {
                            DepartureTime = date.AddDays(i),
                            Vehicle = vehicle
                        });
                    }
                }
            }

            companies.Add(new Company()
            {
                CompanyName = "F Firması",
                Username = "F",
                Password = "F",
                Vehicles = new List<Vehicle>()
                {
                    new Airplane()
                    {
                        Capacity = 30,
                        fuelType = "Gaz",
                        id = "21",
                        Model = "456",
                    },
                    new Airplane()
                    {
                        Capacity = 30,
                        fuelType = "Gaz",
                        id = "22",
                        Model = "457",
                    },
                },
            });
            date = DateTime.Parse("04/12/2023");
            for (int i = 0; i < 7; i++)
            {
                foreach (var vehicle in companies[4].Vehicles)
                {
                    companies[4].TripList.Add(new Trip(Data.guzergah6)
                    {
                        DepartureTime = date.AddDays(i),
                        Vehicle = vehicle
                    });
                }
            }
            foreach (var item in companies)
            {
                item.serviceFee = 1000;
                listBox1.Items.Add(item.CompanyName + "-" + item.Username + "-" + item.Password + "-" + item.serviceFee);
            }
        }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label5_Click(object sender, EventArgs e)
            {

            }

            private void textBox4_TextChanged(object sender, EventArgs e)
            {

            }

            private void firmaKayıtButonu_Click(object sender, EventArgs e)
            {
                Company yenişirket = new Company();
                yenişirket.CompanyName = textBox1.Text;
                yenişirket.Username = textBox2.Text;
                yenişirket.Password = textBox3.Text;
                yenişirket.serviceFee = float.Parse(hizmetbedeli.ToString());

                companies.Add(yenişirket);
                listboxUpdate();

            }

            void listboxUpdate()
            {

                listBox1.Items.Clear();
                foreach (Company company in companies)
                {
                    listBox1.Items.Add(company.CompanyName + " - " + company.Username + " - " + company.Password + " - " + company.serviceFee);// liste en başta sonra add sonra ne ekleyeceğin 
                }

            }

            private void CompanyDeleteButton_Click(object sender, EventArgs e)
            {
                companies.RemoveAt(listBox1.SelectedIndex);
                listboxUpdate();
            }

            private void çıkış_Click(object sender, EventArgs e)
            {

                this.Visible = false;
                Program.LoginPanel.Visible = true;
            }

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            Console.WriteLine(listBox1.SelectedIndex);
            }
        }
    
}
