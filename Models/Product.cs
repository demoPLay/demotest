using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demotest.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Display(Name = "ID sản phẩm" )]
        public string ProductID { get; set; }
        [Display(Name = "tên sản phẩm")]
        public decimal ProductName { get; set; }
        [Display(Name = "đơn giá")]
        public decimal UnitPrice { get; set; }
        [Display(Name = "số lượng")]
        public decimal Quantity { get; set; }
    }
}