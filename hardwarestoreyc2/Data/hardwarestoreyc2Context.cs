using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace hardwarestoreyc2.Models
{
    public class hardwarestoreyc2Context : DbContext
    {
        public hardwarestoreyc2Context (DbContextOptions<hardwarestoreyc2Context> options)
            : base(options)
        {
        }

        public DbSet<hardwarestoreyc2.Models.Product> Product { get; set; }
    }
}
