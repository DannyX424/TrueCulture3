using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrueCulture3.Models;

namespace TrueCulture3.Models
{
    
    public class TC3Context : DbContext
    {
        public TC3Context(DbContextOptions<TC3Context> options) : base(options)
        {
            
        }
        public DbSet<TC3Context> Translations;
        public DbSet<TrueCulture3.Models.Translation> Translation { get; set; }
    }
}
