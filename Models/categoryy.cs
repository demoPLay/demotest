using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace demotest.Models
{
    [Table("categoryss")]
    public class categoryy
    {
        [Key]
        [Display(Name = "mã thể loại")]
        public string categoryyID { get; set; }
        
        [Display(Name = "ten thể loại ")]
        public string categoryyName { get; set; }
        public ICollection<Productt> Productts {get; set; }

    }
}