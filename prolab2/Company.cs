using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public class Company : User, IProfitable
    {

        public string CompanyName { get; set; }
        public decimal DailyIncome { get; set; }
        public decimal OverallIncome { get; set; }

        public float serviceFee { get; set; }


        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public List<Trip> TripList { get; set; } = new List<Trip>();

        public void CalculateDailyProfit()
        { }

        public void CalculateOverallProfit()
        {
        }

        public void CalculateOverallProfitLoss()
        {
        }

        public override void Login()
        {
        }
    }
}
