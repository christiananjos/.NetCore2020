using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzaria.Data.Migrations
{
    public partial class Pizzaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(type: "Varchar(200)", nullable: true),
                    NumeroCasa = table.Column<string>(type: "Varchar(20)", nullable: true),
                    Complemento = table.Column<string>(type: "Varchar(50)", nullable: true),
                    Bairro = table.Column<string>(type: "Varchar(50)", nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    UF = table.Column<string>(type: "Char(2)", nullable: true),
                    Telefone = table.Column<string>(type: "Varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUsuarioSistema = table.Column<string>(type: "Varchar(50)", nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    ValorFrete = table.Column<decimal>(type: "Money", nullable: false),
                    ValorTotalPedido = table.Column<decimal>(type: "Money", nullable: false),
                    DtHoraPedido = table.Column<DateTime>(type: "Datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrição = table.Column<string>(type: "Varchar(150)", nullable: true),
                    Valor = table.Column<decimal>(type: "Money", nullable: false),
                    PedidoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_PedidoId",
                table: "Items",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
