using Microsoft.EntityFrameworkCore.Migrations;

namespace Listasupermercado.Infrastructure.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Carrinhos_CarrinhoEntityId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_CarrinhoEntityId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "CarrinhoEntityId",
                table: "Produtos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarrinhoEntityId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CarrinhoEntityId",
                table: "Produtos",
                column: "CarrinhoEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Carrinhos_CarrinhoEntityId",
                table: "Produtos",
                column: "CarrinhoEntityId",
                principalTable: "Carrinhos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
