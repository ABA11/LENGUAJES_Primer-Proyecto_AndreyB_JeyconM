using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LENGUAJES_Primer_Proyecto_AndreyBermdez_JeyconMorera.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anime",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true),
                    CEpisodios = table.Column<int>(nullable: false),
                    Ranking = table.Column<string>(nullable: true),
                    AñoEmision = table.Column<DateTime>(nullable: false),
                    AñoFinalizacion = table.Column<DateTime>(nullable: false),
                    Duracion = table.Column<int>(nullable: false),
                    EstDescarga = table.Column<bool>(nullable: false),
                    EstEmision = table.Column<bool>(nullable: false),
                    Estado = table.Column<bool>(nullable: false),
                    TotalEpisodios = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anime", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ova",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Año = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Capitulos = table.Column<int>(nullable: false),
                    Duracion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ova", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pelicula",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Año = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Duracion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pelicula", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Temporada",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Año = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Capitulos = table.Column<int>(nullable: false),
                    Duracion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temporada", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anime");

            migrationBuilder.DropTable(
                name: "Ova");

            migrationBuilder.DropTable(
                name: "Pelicula");

            migrationBuilder.DropTable(
                name: "Temporada");
        }
    }
}
