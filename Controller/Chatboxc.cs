using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarParkingManagementSystem.Models;

namespace CarParkingManagementSystem.Controller
{
    public class Chatboxc
    {
        Chatbox l = new Chatbox();


        public string From { get; set; }
        public string To { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string DT { get; set; }
        public string Toi { get; set; }
        public string Fromi { get; set; }

    }
}
