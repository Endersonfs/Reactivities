using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Activity;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DbSet<Activity> Activities { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {
            //Activity
            
        }        
    }
}