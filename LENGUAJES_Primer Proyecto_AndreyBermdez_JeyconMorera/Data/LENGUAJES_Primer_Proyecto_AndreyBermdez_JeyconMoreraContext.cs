using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Models;

namespace LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Models
{
    public class LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMoreraContext : DbContext
    {
        public LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMoreraContext (DbContextOptions<LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMoreraContext> options)
            : base(options)
        {
        }

        public DbSet<LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Models.Anime> Anime { get; set; }

        public DbSet<LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Models.Ova> Ova { get; set; }

        public DbSet<LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Models.Pelicula> Pelicula { get; set; }

        public DbSet<LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Models.Temporada> Temporada { get; set; }
    }
}
