using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TesteSawLuz.Infra.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Restaurante",
                schema: "dbo",
                columns: table => new
                {
                    IdRestaurante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurante", x => x.IdRestaurante);
                });

            migrationBuilder.CreateTable(
                name: "Prato",
                schema: "dbo",
                columns: table => new
                {
                    IdPrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdRestaurante = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prato", x => x.IdPrato);
                    table.ForeignKey(
                        name: "FK_Prato_Restaurante_IdRestaurante",
                        column: x => x.IdRestaurante,
                        principalSchema: "dbo",
                        principalTable: "Restaurante",
                        principalColumn: "IdRestaurante",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prato_IdRestaurante",
                schema: "dbo",
                table: "Prato",
                column: "IdRestaurante");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prato",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Restaurante",
                schema: "dbo");
        }
    }
}
