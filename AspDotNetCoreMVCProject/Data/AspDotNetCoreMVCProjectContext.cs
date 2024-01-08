using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspDotNetCoreMVCProject.Models;

namespace AspDotNetCoreMVCProject.Data
{
    public class AspDotNetCoreMVCProjectContext : DbContext
    {
        public AspDotNetCoreMVCProjectContext (DbContextOptions<AspDotNetCoreMVCProjectContext> options)
            : base(options)
        {
        }

        public DbSet<AspDotNetCoreMVCProject.Models.User> User { get; set; } = default!;

        public DbSet<AspDotNetCoreMVCProject.Models.Product>? Product { get; set; }
    }
}
