using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Models
{
    public class LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMoreraContext : DbContext
    {
        public LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMoreraContext (DbContextOptions<LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMoreraContext> options)
            : base(options)
        {
        }

        public DbSet<LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Models.Anime> Anime { get; set; }
    }
}
