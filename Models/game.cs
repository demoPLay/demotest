using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demotest.Models
{
    public class game : person
    {
        [Display(Name = "mã game")]
        public string gameID { get; set; }
        
        [Display(Name = "ten game")]
        public decimal gameName { get; set; }
    }
}