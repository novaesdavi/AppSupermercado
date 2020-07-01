using Microsoft.EntityFrameworkCore.Migrations;

namespace Listasupermercado.Infrastructure.Migrations
{
    public partial class itemcarrinho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemCarrinhoEntityCarrinhoId",
                table: "Produtos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemCarrinhoEntityProdutoId",
                table: "Produtos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemCarrinhoEntityCarrinhoId",
                table: "Carrinhos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemCarrinhoEntityProdutoId",
                table: "Carrinhos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ItemCarrinho",
                columns: table => new
                {
                    CarrinhoId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCarrinho", x => new { x.CarrinhoId, x.ProdutoId });
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrinhos_ItemCarrinho_ItemCarrinhoEntityCarrinhoId_ItemCarrinhoEntityProdutoId",
                table: "Carrinhos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_ItemCarrinho_ItemCarrinhoEntityCarrinhoId_ItemCarrinhoEntityProdutoId",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "ItemCarrinho");

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
        }
    }
}
