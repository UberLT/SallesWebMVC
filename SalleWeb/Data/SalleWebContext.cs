using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalleWeb.Models;

namespace SalleWeb.Data
{
    public class SalleWebContext : DbContext
    {
        public SalleWebContext (DbContextOptions<SalleWebContext> options)
            : base(options)
        {
        }

        public DbSet<SalleWeb.Models.Department> Department { get; set; } = default!;
    }
}
