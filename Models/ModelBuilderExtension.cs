using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreAsp2.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    Name="张三",
                    Major=MajorEnum.ElectronicCommerce,
                    Email="12298@qq.com"
                    
                }
                );
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 2,
                    Name = "王五",
                    Major = MajorEnum.Mathematics,
                    Email = "9564431594@qq.com"
                }
                );
        }
    }
}
