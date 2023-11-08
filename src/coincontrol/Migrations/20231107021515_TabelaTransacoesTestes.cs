using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coincontrol.Migrations
{
    /// <inheritdoc />
    public partial class TabelaTransacoesTestes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "transacoesTestes",
                columns: table => new
                {
                    idTransacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuario = table.Column<int>(type: "int", nullable: false),
                    idCarteira = table.Column<int>(type: "int", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idCategoria = table.Column<int>(type: "int", nullable: false),
                    modalidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transacoesTestes", x => x.idTransacao);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {           
            migrationBuilder.DropTable(
                name: "transacoesTestes");
        }
    }
}
