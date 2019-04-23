using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hnl.veiculos.com.br.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IMAGEM = table.Column<string>(maxLength: 255, nullable: false),
                    NOME = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    NOME = table.Column<string>(maxLength: 255, nullable: false),
                    IMAGEM = table.Column<string>(nullable: true),
                    MARCA = table.Column<string>(nullable: true),
                    IDMARCA = table.Column<Guid>(nullable: false),
                    MarcaID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Modelos_Marca_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marca",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_MarcaID",
                table: "Modelos",
                column: "MarcaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}
