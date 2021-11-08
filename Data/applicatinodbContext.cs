using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using demotest.Models;
using demotest.data;

namespace demotest.data 
{
    public class applicatinodbContext : DbContext
    {
        public applicatinodbContext (DbContextOptions<applicatinodbContext> options)
            : base(options)
        {
        }

        public DbSet<demotest.Models.test> test { get; set; }

        public DbSet<demotest.Models.preson> preson { get; set; }

        public DbSet<demotest.Models.person> person { get; set; }

        public DbSet<demotest.Models.Student> Student { get; set; }

        public DbSet<demotest.Models.Employee> Employee { get; set; }

        public DbSet<demotest.Models.Product> Product { get; set; }
        public object Movie { get; internal set; }
    }
}