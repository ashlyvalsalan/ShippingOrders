using Microsoft.EntityFrameworkCore.Migrations;

namespace ShippingOrders.Migrations
{
    public partial class migration15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Orders_OrdersShipperOrderId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_OrdersShipperOrderId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "OrdersShipperOrderId",
                table: "Items");

            migrationBuilder.AddColumn<string>(
                name: "ItemCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemsItemCode",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ItemsItemCode",
                table: "Orders",
                column: "ItemsItemCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Items_ItemsItemCode",
                table: "Orders",
                column: "ItemsItemCode",
                principalTable: "Items",
                principalColumn: "ItemCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Items_ItemsItemCode",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ItemsItemCode",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ItemCode",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ItemsItemCode",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "OrdersShipperOrderId",
                table: "Items",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_OrdersShipperOrderId",
                table: "Items",
                column: "OrdersShipperOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Orders_OrdersShipperOrderId",
                table: "Items",
                column: "OrdersShipperOrderId",
                principalTable: "Orders",
                principalColumn: "ShipperOrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
