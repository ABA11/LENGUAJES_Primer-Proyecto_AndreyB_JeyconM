using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Models
{
    public class Anime
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Clasificacion { get; set; }
        public byte[] Foto { get; set; }
        public int CEpisodios { get; set; }
        public string Ranking { get; set; }
        public DateTime AñoEmision { get; set; }
        public DateTime AñoFinalizacion { get; set; }
        public int Duracion { get; set; }
        public bool EstDescarga { get; set; }
        public string EstEmision { get; set; }
        public string Estado { get; set; }
        public int TotalEpisodios { get; set; }
    }
}
