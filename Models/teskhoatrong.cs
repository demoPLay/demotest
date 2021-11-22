using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace demotest.Models
{
    [Table("teskhoatrong")]
    public class teskhoatrong
    {
        [Key]
        [Display(Name = "mã teskhoatrong")]
        public string teskhoatrongID { get; set; }
        
        [Display(Name = "ten teskhoatrong ")]
        public string teskhoatrongName { get; set; }
        public ICollection<demokhoangoai> demokhoangoai {get; set; }

    }
}