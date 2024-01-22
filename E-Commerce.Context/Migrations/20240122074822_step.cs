using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Context.Migrations
{
    /// <inheritdoc />
    public partial class step : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Carts_cartId",
                table: "CartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Products_ProductId",
                table: "CartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Orders",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                newName: "IX_Orders_UserID");

            migrationBuilder.RenameColumn(
                name: "cartId",
                table: "CartDetails",
                newName: "cartID");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "CartDetails",
                newName: "productID");

            migrationBuilder.RenameIndex(
                name: "IX_CartDetails_ProductId",
                table: "CartDetails",
                newName: "IX_CartDetails_productID");

            migrationBuilder.RenameIndex(
                name: "IX_CartDetails_cartId",
                table: "CartDetails",
                newName: "IX_CartDetails_cartID");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Carts_cartID",
                table: "CartDetails",
                column: "cartID",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Products_productID",
                table: "CartDetails",
                column: "productID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserID",
                table: "Orders",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Carts_cartID",
                table: "CartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Products_productID",
                table: "CartDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "image",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "image",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Orders",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.RenameColumn(
                name: "productID",
                table: "CartDetails",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "cartID",
                table: "CartDetails",
                newName: "cartId");

            migrationBuilder.RenameIndex(
                name: "IX_CartDetails_productID",
                table: "CartDetails",
                newName: "IX_CartDetails_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CartDetails_cartID",
                table: "CartDetails",
                newName: "IX_CartDetails_cartId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Carts_cartId",
                table: "CartDetails",
                column: "cartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Products_ProductId",
                table: "CartDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
