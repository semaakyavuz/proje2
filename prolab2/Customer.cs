using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public class Customer : User
    {
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public string TC { get; set; } = string.Empty;
        public DateTime BornTime { get; set; } = DateTime.Now;
        public void SearchTransport()
        {
        }

        public void MakeReservation()
        { }
        
        public override void Login()
        {
            
        }
    }
}
