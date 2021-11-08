using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demotest.Models
{
    [Table("preson")]
    public class preson
    {
        [Key]
        [Display(Name = "mã")]
        public string nameID { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày phát hành")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "thể loại")]
        public string Genre { get; set; }
        [Display(Name = "giá bán")]
        public decimal Price { get; set; }
    }
}