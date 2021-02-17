using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fichas.ModelsSoa
{
    public class SOAContext : DbContext
    {
        public SOAContext()
        {
        }

        public SOAContext(DbContextOptions<SOAContext> options) : base(options)
        {
        }

        public virtual DbSet<Tb_Cad_Pessoa> Tb_Cad_Pessoa { get; set; }

    }
}
