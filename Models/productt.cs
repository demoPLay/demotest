using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demotest.Models
{
    [Table("Productt")]
    public class Productt
    {
        [Key]
        [Display(Name = "ID sản phẩm" )]
        public string ProducttID { get; set; }
        [Display(Name = "tên sản phẩm")]
        public string ProducttName { get; set; }
        [Display(Name = "đơn giá")]
        public string UnitPrice { get; set; }
        [Display(Name = "số lượng")]
        public string Quantity { get; set; }
        public string categoryyID { get; set; }
        public categoryy categoryy { get; set; }
    }
}