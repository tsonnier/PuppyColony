using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IdleGame1.Models
{
    public class Resource
    {
        [ScaffoldColumn(false)]
        public int ResourceID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string Name { get; set; }

        [Required, StringLength(10000), Display(Name = "Resource Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int? Quantity { get; set; }

        public bool Unlocked { get; set; }
    }
}