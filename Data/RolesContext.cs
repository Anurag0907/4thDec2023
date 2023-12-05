using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _4thDec2023.Models;

namespace _4thDec2023.Data
{
    public class RolesContext : DbContext
    {
        public RolesContext (DbContextOptions<RolesContext> options)
            : base(options)
        {
        }

        public DbSet<_4thDec2023.Models.User> User { get; set; } = default!;
    }
}
