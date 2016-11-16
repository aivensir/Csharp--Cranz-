using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;

namespace Cranz1.Models
{
    public class Deed
    {
        public int DeedID { get; set; }
        public int AuthorID { get; set; }
        public string Contain { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("AuthorID")]
        public virtual User Author { get; set; }

        
    }
}