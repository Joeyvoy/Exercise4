using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Exercise4.Models;

namespace Exercise4.Data
{
    public class Exercise4Context : DbContext
    {
        public Exercise4Context (DbContextOptions<Exercise4Context> options)
            : base(options)
        {
        }

        public DbSet<Exercise4.Models.CustomerModel> CustomerModel { get; set; }
    }
}
