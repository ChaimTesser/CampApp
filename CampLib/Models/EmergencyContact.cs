using System;
using System.Collections.Generic;
using System.Text;

namespace CampLib.Models
{
    public class EmergencyContact
    {
        public int EmergencyContactID { get; set; }
        public string Name { get; set; }
        public Phone Phone { get; set; }
        public string Relationship { get; set; }

    }
}
