using System;
using System.Collections.Generic;
using System.Text;

namespace CampLib.Models
{
    public class Phone
    {
        public int PhoneID { get; set; }
        public string PhoneNumber { get; set; }
        public PhoneType PhoneType { get; set; }
    }
    public enum PhoneType
    {
        Home = 1,
        Cell,
        Work,
        Other
    }
}
