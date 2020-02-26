using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCoreSigna.Model
{
    public class ApiDbContext: DbContext
    {


        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {}

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Dog> Dogs { get; set; }

    }
}
