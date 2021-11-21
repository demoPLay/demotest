using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace demotest.Models
{
    [Table("categorys")]
    public class category
    {
        [Key]
        [Display(Name = "mã thể loại")]
        public string categoryID { get; set; }
        
        [Display(Name = "ten thể loại ")]
        public string categoryName { get; set; }
        public ICollection<Product> Products {get; set; }

    }
}