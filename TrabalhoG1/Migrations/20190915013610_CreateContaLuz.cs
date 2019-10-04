using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TrabalhoG1.Migrations
{
    public partial class CreateContaLuz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContasLuz",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    dataLeitura = table.Column<DateTime>(nullable: false),
                    kwGasto = table.Column<int>(nullable: false),
                    valorAPagar = table.Column<double>(nullable: false),
                    dataPagamento = table.Column<DateTime>(nullable: false),
                    mediaConsumo = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContasLuz", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContasLuz");
        }
    }
}
