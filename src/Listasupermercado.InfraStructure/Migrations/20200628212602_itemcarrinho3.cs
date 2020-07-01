using Microsoft.EntityFrameworkCore.Migrations;

namespace Listasupermercado.Infrastructure.Migrations
{
    public partial class itemcarrinho3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemCarrinho_Carrinhos_CarrinhoId",
                table: "ItemCarrinho");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemCarrinho_Produtos_ProdutoId",
                table: "ItemCarrinho");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCarrinho",
                table: "ItemCarrinho");

            migrationBuilder.RenameTable(
                name: "ItemCarrinho",
                newName: "ItensCarrinhos");

            migrationBuilder.RenameIndex(
                name: "IX_ItemCarrinho_ProdutoId",
                table: "ItensCarrinhos",
                newName: "IX_ItensCarrinhos_ProdutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItensCarrinhos",
                table: "ItensCarrinhos",
                columns: new[] { "CarrinhoId", "ProdutoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ItensCarrinhos_Carrinhos_CarrinhoId",
                table: "ItensCarrinhos",
                column: "CarrinhoId",
                principalTable: "Carrinhos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensCarrinhos_Produtos_ProdutoId",
                table: "ItensCarrinhos",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensCarrinhos_Carrinhos_CarrinhoId",
                table: "ItensCarrinhos");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensCarrinhos_Produtos_ProdutoId",
                table: "ItensCarrinhos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItensCarrinhos",
                table: "ItensCarrinhos");

            migrationBuilder.RenameTable(
                name: "ItensCarrinhos",
                newName: "ItemCarrinho");

            migrationBuilder.RenameIndex(
                name: "IX_ItensCarrinhos_ProdutoId",
                table: "ItemCarrinho",
                newName: "IX_ItemCarrinho_ProdutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCarrinho",
                table: "ItemCarrinho",
                columns: new[] { "CarrinhoId", "ProdutoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCarrinho_Carrinhos_CarrinhoId",
                table: "ItemCarrinho",
                column: "CarrinhoId",
                principalTable: "Carrinhos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCarrinho_Produtos_ProdutoId",
                table: "ItemCarrinho",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
