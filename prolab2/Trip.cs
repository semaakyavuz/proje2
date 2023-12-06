using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public class Trip
    {
        public List<Route> RouteList = new List<Route>();
        public DateTime DepartureTime { get; set; }
        public decimal Price { get; set; }
        public Company Company { get; set; }
        public Vehicle Vehicle { get; set; }
        public Trip(List<string> guzergah) 
        {
            RouteList = new List<Route>();
            for (int i = 0; i < guzergah.Count - 1; i++)
            {
                for (int j = i + 1; j < guzergah.Count; j++)
                {
                    if (guzergah[i] != guzergah[j])
                    {
                        if(RouteList.Find(x=> x.DepartureLocation == guzergah[i] && x.ArrivalLocation == guzergah[j]) == null)
                        {
                            RouteList.Add(new Route { DepartureLocation= guzergah[i],ArrivalLocation= guzergah[j] });
                        }
                        if (RouteList.Find(x => x.DepartureLocation == guzergah[j] && x.ArrivalLocation == guzergah[i]) == null)
                        {
                            RouteList.Add(new Route { DepartureLocation = guzergah[j], ArrivalLocation = guzergah[i] });
                        }
                    }
                }
            }
        }

}
}
