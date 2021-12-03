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
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        [Display(Name = "giá bán")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }
    }
}