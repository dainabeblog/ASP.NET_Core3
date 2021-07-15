using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SampleBlazorApp.Data
{
    public class Mydata
    {
        [Required]
        public string Name { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        public string Mail { get; set; }


        public override string ToString()
        {
            return "[" + Name + " (" + Password + ") " + Mail + "]";
        }
    }
}