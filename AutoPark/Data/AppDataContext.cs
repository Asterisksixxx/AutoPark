using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoPark.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoPark.Data
{
    public class AppDataContext:DbContext

    {
        public AppDataContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Auto> autos { get; set; }
    }
}
