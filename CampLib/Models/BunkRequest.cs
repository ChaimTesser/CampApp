using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CampLib.Models
{
    class BunkRequest
    {
        [Key]
        public int BunkRequestID { get; set; }
        public string Name { get; set; }
        public int CamperID { get; set; }
    }
}
