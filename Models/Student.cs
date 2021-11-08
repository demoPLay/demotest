using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demotest.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [Display(Name = "ID sinh viên" )]
        public string StudentID { get; set; }
        [Display(Name = "tên sinh viên" )]
        public decimal StudentName { get; set; }
        [Display(Name = "địa chỉ sinh viên" )]
        public decimal Address { get; set; }
    }
}