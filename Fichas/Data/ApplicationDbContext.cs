using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fichas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Fichas.Models.Ficha> Ficha { get; set; }
        public DbSet<Fichas.Models.Acampante> Acampante { get; set; }
        public DbSet<Fichas.Models.Responsavel> Responsavel { get; set; }
    }
}
