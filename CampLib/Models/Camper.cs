using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CampLib.Models
{
    public class Camper
    {
        [Key]
        public int CamperID { get; set; }
        public int PublicID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Phone> Phone { get; set; }
        public Email Email { get; set; }
        public ICollection<Parent> Parents { get; set; }
        public ICollection<EmergencyContact> EmergencyContacts { get; set; }

    }
}
