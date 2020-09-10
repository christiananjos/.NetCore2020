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

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Bairro", "Cep", "Complemento", "Estado", "Logradouro", "NomeCliente", "NumeroCasa", "Telefone", "UF" },
                values: new object[,]
                {
                    { 1, "Jd Bartira", "0851000", "Bloco 6 Apto 11", "São Paulo", "Estrada Dom João Nery", "Christian", "3551", "1199299999", "SP" },
                    { 2, "Jd Bartira", "0851000", "Bloco 6 Apto 11", "São Paulo", "Estrada Dom João Nery 2", "Douglas", "3552", "1199298888", "SP" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Descrição", "PedidoId", "Valor" },
                values: new object[,]
                {
                    { 26, "1/2 Pepperoni + 1/2 Portuguesa", null, 100m },
                    { 25, "1/2 Calabresa + 1/2 Veggie", null, 102.49m },
                    { 24, "1/2 Calabresa + 1/2 Portuguesa", null, 87.5m },
                    { 23, "1/2 Calabresa + 1/2 Pepperoni", null, 97.5m },
                    { 22, "1/2 Mussarela + 1/2 Veggie", null, 102.49m },
                    { 21, "1/2 Mussarela + 1/2 Portuguesa", null, 87.5m },
                    { 20, "1/2 Mussarela + 1/2 Pepperoni", null, 97.5m },
                    { 19, "1/2 Mussarela + Calabresa", null, 85m },
                    { 18, "1/2 Frango com requeijão + Veggie", null, 119.98m },
                    { 17, "1/2 Frango com requeijão + Portuguesa", null, 104.99m },
                    { 16, "1/2 Frango com requeijão + Pepperoni", null, 114.99m },
                    { 15, "1/2 Frango com requeijão + Calabresa", null, 102.49m },
                    { 14, "1/2 Frango com requeijão + Mussarela", null, 102.49m },
                    { 13, "1/2 3 queijos + 1/2 Veggie", null, 109.99m },
                    { 12, "1/2 3 queijos + 1/2 Portuguesa", null, 95m },
                    { 11, "1/2 3 queijos + 1/2 Pepperoni", null, 55m },
                    { 10, "1/2 3 queijos + 1/2 Calabresa", null, 92.5m },
                    { 9, "1/2 3 queijos + 1/2 Mussarela", null, 92.5m },
                    { 8, "1/2 3 queijos + 1/2 Frango com requeijão", null, 109.99m },
                    { 7, "Veggie", null, 59.99m },
                    { 6, "Portuguesa", null, 45m },
                    { 5, "Pepperoni", null, 55m },
                    { 4, "Calabresa", null, 42.5m },
                    { 3, "Mussarela", null, 42.5m },
                    { 2, "Frango com requeijão", null, 59.99m },
                    { 1, "3 Queijos", null, 50m },
                    { 27, "1/2 Pepperoni + 1/2 Veggie", null, 114.99m },
                    { 28, "1/2 Portuguesa + 1/2 Veggie", null, 104.99m }
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
