using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarParkingManagementSystem.Models;

namespace CarParkingManagementSystem.Controller
{
    public class Bookingc
    {
        Booking0 l = new Booking0();


        public string parkerid { get; set; }
        public string ownerid { get; set; }
        public string freeslot { get; set; }
        public string datetime { get; set; }
        public string stime { get; set; }
        public string etime { get; set; }
        public string estimatedtime { get; set; }
        public string estimatedcost { get; set; }
        public string status { get; set; }
    }
}
