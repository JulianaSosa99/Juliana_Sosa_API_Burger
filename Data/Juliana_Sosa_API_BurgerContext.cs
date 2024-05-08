using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Juliana_Sosa_API_Burger.Data.Models;

namespace Juliana_Sosa_API_Burger.Data
{
    public class Juliana_Sosa_API_BurgerContext : DbContext
    {
        public Juliana_Sosa_API_BurgerContext (DbContextOptions<Juliana_Sosa_API_BurgerContext> options)
            : base(options)
        {
        }

        public DbSet<Juliana_Sosa_API_Burger.Data.Models.Burger> Burger { get; set; } = default!;
    }
}
