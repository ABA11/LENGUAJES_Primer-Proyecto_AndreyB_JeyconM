﻿// <auto-generated />
using System;
using LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Migrations
{
    [DbContext(typeof(LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMoreraContext))]
    partial class LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMoreraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Models.Anime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AñoEmision");

                    b.Property<DateTime>("AñoFinalizacion");

                    b.Property<int>("CEpisodios");

                    b.Property<int>("Duracion");

                    b.Property<bool>("EstDescarga");

                    b.Property<bool>("EstEmision");

                    b.Property<bool>("Estado");

                    b.Property<byte[]>("Foto");

                    b.Property<string>("Nombre");

                    b.Property<string>("Ranking");

                    b.Property<int>("TotalEpisodios");

                    b.HasKey("Id");

                    b.ToTable("Anime");
                });

            modelBuilder.Entity("LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Models.Ova", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Año");

                    b.Property<int>("Capitulos");

                    b.Property<int>("Duracion");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Ova");
                });

            modelBuilder.Entity("LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Models.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Año");

                    b.Property<int>("Duracion");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Pelicula");
                });

            modelBuilder.Entity("LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Models.Temporada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Año");

                    b.Property<int>("Capitulos");

                    b.Property<int>("Duracion");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Temporada");
                });
#pragma warning restore 612, 618
        }
    }
}
