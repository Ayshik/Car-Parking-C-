using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarParkingManagementSystem.Models;


namespace CarParkingManagementSystem.Controller
{
    public class Ownerdetailsc
    {
        Ownerdetails l = new Ownerdetails();

        public string Password { get; set; }
        public string Userid { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string mobileno { get; set; }
        public string address { get; set; }
        public string space { get; set; }

        public string road { get; set; }
        public string house { get; set; }
        public string block { get; set; }


    }
}
