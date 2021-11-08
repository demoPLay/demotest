using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demotest.Models
{
    [Table("Employee")]
    public class Employee   
    {
        [Key]
        [Display(Name = "Mã hiệu công nhân")]
        public string EmployeeID { get; set; }
        [Display(Name = "tên công nhân")]
        public string  EmployeeName { get; set; }
        [Display(Name = "số điện thoại")]
        public string PhoneNumber { get; set; }
    }
}