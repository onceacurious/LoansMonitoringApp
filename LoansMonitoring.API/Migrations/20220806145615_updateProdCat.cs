using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoansMonitoring.API.Migrations
{
    public partial class updateProdCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductModelId",
                table: "ProductCategories");

            migrationBuilder.RenameColumn(
                name: "ProductModelId",
                table: "ProductCategories",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategories_ProductModelId",
                table: "ProductCategories",
                newName: "IX_ProductCategories_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_ProductId",
                table: "ProductCategories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductId",
                table: "ProductCategories");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductCategories",
                newName: "ProductModelId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategories_ProductId",
                table: "ProductCategories",
                newName: "IX_ProductCategories_ProductModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_ProductModelId",
                table: "ProductCategories",
                column: "ProductModelId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
