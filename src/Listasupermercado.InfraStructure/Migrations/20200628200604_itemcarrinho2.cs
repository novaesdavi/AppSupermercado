using Microsoft.EntityFrameworkCore.Migrations;

namespace Listasupermercado.Infrastructure.Migrations
{
    public partial class itemcarrinho2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrinhos_ItemCarrinho_ItemCarrinhoEntityCarrinhoId_ItemCarrinhoEntityProdutoId",
                table: "Carrinhos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_ItemCarrinho_ItemCarrinhoEntityCarrinhoId_ItemCarrinhoEntityProdutoId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_ItemCarrinhoEntityCarrinhoId_ItemCarrinhoEntityProdutoId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Carrinhos_ItemCarrinhoEntityCarrinhoId_ItemCarrinhoEntityProdutoId",
                table: "Carrinhos");

            migrationBuilder.DropColumn(
                name: "ItemCarrinhoEntityCarrinhoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ItemCarrinhoEntityProdutoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ItemCarrinhoEntityCarrinhoId",
                table: "Carrinhos");

            migrationBuilder.DropColumn(
                name: "ItemCarrinhoEntityProdutoId",
                table: "Carrinhos");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCarrinho_ProdutoId",
                table: "ItemCarrinho",
                column: "ProdutoId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemCarrinho_Carrinhos_CarrinhoId",
                table: "ItemCarrinho");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemCarrinho_Produtos_ProdutoId",
                table: "ItemCarrinho");

            migrationBuilder.DropIndex(
                name: "IX_ItemCarrinho_ProdutoId",
                table: "ItemCarrinho");

            migrationBuilder.AddColumn<int>(
                name: "ItemCarrinhoEntityCarrinhoId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemCarrinhoEntityProdutoId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemCarrinhoEntityCarrinhoId",
                table: "Carrinhos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemCarrinhoEntityProdutoId",
                table: "Carrinhos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ItemCarrinhoEntityCarrinhoId_ItemCarrinhoEntityProdutoId",
                table: "Produtos",
                columns: new[] { "ItemCarrinhoEntityCarrinhoId", "ItemCarrinhoEntityProdutoId" });

            migrationBuilder.CreateIndex(
                name: "IX_Carrinhos_ItemCarrinhoEntityCarrinhoId_ItemCarrinhoEntityProdutoId",
                table: "Carrinhos",
                columns: new[] { "ItemCarrinhoEntityCarrinhoId", "ItemCarrinhoEntityProdutoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Carrinhos_ItemCarrinho_ItemCarrinhoEntityCarrinhoId_ItemCarrinhoEntityProdutoId",
                table: "Carrinhos",
                columns: new[] { "ItemCarrinhoEntityCarrinhoId", "ItemCarrinhoEntityProdutoId" },
                principalTable: "ItemCarrinho",
                principalColumns: new[] { "CarrinhoId", "ProdutoId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_ItemCarrinho_ItemCarrinhoEntityCarrinhoId_ItemCarrinhoEntityProdutoId",
                table: "Produtos",
                columns: new[] { "ItemCarrinhoEntityCarrinhoId", "ItemCarrinhoEntityProdutoId" },
                principalTable: "ItemCarrinho",
                principalColumns: new[] { "CarrinhoId", "ProdutoId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
