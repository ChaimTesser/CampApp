using System;
using System.Collections.Generic;
using System.Text;

namespace CampLib.Models
{
    public class Parent
    {
        public int ParentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ParentType ParentType { get; set; }
        public string GuardianRelationship { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Phone> Phones { get; set; }
        public Email Email { get; set; }
    }
    public enum ParentType
    {
        Mother,
        Father,
        Gaurdian
    }
}
