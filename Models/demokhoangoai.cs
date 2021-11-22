using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demotest.Models
{
    [Table("demokhoangoai")]
    public class demokhoangoai
    {
        [Key]
        [Display(Name = "ID demokhoangoai" )]
        public string demokhoangoaiID { get; set; }
        [Display(Name = "tên demokhoangoai")]
        public string demokhoangoaiName { get; set; }
        [Display(Name = "đơn giá demokhoangoai")]
        public string UnitPrice { get; set; }
        [Display(Name = "số lượng")]
        public string Quantity { get; set; }
        public string teskhoatrongID { get; set; }
        public teskhoatrong teskhoatrong {get; set; }
    }
}