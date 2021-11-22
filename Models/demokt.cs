using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demotest.Models
{
    public class demokt : Student
    {
        [Display(Name = "ID ke thua")]
        public string demoktID { get; set; }
        
        [Display(Name = "ten ke thua")]
        public decimal demoktName { get; set; }
    }
}