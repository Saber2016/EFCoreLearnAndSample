using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreAsp2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MajorEnum? Major { get; set; }
        public string Email { get; set; }
    }

    public enum MajorEnum
    {
        [Display(Name ="未分配")]
        None,
        [Display(Name = "计算机科学")]
        ComputeScience,
        [Display(Name = "电子商务")]
        ElectronicCommerce,
        [Display(Name = "数学")]
        Mathematics

    }

}
