using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public abstract class Vehicle
    {
        public string id { get; set; }
        public string fuelType { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public int BosKoltukSayisi { get; set; }
        public List<int> DoluKoltukIndexes { get; set; }
        public List<int> RezerveKoltukIndexes { get; set; }
        public Vehicle() 
        {
            DoluKoltukIndexes = new List<int>();
            RezerveKoltukIndexes = new List<int>();
        }

        public void BosKoltukHesapla()
        {
            BosKoltukSayisi = Capacity - (DoluKoltukIndexes.Count + RezerveKoltukIndexes.Count); 
        }

        public void KoltukDoldur(int index)
        {
            DoluKoltukIndexes.Add(index);
            BosKoltukHesapla();
        }

        public void KoltukRezerve(int index)
        {
            RezerveKoltukIndexes.Add(index);
            BosKoltukHesapla();
        }
        public void KoltukRezerveKaldir(int index)
        {
            RezerveKoltukIndexes.Remove(index);
            BosKoltukHesapla();
        }



        public abstract void CalculateFuelCost();
    }
}
