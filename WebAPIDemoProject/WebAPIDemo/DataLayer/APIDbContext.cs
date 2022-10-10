using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAPIDemo.DataLayer
{
    public class APIDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        public APIDbContext(DbContextOptions<APIDbContext> options) : base (options) {}
    }
}