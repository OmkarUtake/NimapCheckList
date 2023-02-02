using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelperTags.Models
{
    public class Students
    {
        [Required(ErrorMessage = "Please Enter id")]
        public int id { get; set; }

        [Required(ErrorMessage = "Enter your Name")]
        public string name { get; set; }

        [Required(ErrorMessage ="Course Required")]
        public string Course { get; set; }


        public bool pass { get; set; }
    }
}