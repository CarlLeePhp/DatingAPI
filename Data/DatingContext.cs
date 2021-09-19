using DatingAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAPI.Data
{
    public class DatingContext: DbContext
    {
        public DatingContext(DbContextOptions options): base(options)
        { }

        public DbSet<AppUser> Users { get; set; }
    }
}
