using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using demotest.data;
using demotest.Models;
using System;
using System.Linq;

namespace demotest.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new applicatinodbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<applicatinodbContext>>()))
            {
                // Look for any movies.
                if (context.Employee.Any())
                {
                    return;   // DB has been seeded
                }

                context.Employee.AddRange(
                    new Employee
                    {
                        EmployeeID = "EMP001",
                        EmployeeName = ("Dinh Thế Nhân"),
                        PhoneNumber = "09129899100",
                       
                    },

                    new Employee
                    {
                         EmployeeID = "EMP002",
                        EmployeeName = ("Phạm Văn Anh"),
                        PhoneNumber = "09139899100",
                    },

                    new Employee   
                    {
                        EmployeeID = "EMP003",
                        EmployeeName = "Nguyễn Quang Đức",
                        PhoneNumber = "09149899100",
                    },

                    new Employee    
                    {
                        EmployeeID = "EMP004",
                        EmployeeName = ("abc"),
                        PhoneNumber = "09159899100",
                    
                    }
                );
               
                context.SaveChanges();
            }
        }
    }
}