using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demotest.Models
{
    [Table("person")]
    public class person
    {
        [Key]
        [Display(Name = "mã người làm")]
        public string PersonID { get; set; }
        
        
        [Display(Name = "tên người làm")]
        public decimal PersonName { get; set; }
    }
}