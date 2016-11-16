using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cranz1.Models
{
    public class UserInfo
    {
        [ForeignKey("User")]
        public int UserID { get; set; }
        public DateTime RegDate { get; set; }
        public string Bio { get; set; }
    }
}