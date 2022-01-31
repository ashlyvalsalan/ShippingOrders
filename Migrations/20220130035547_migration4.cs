using Microsoft.EntityFrameworkCore.Migrations;

namespace ShippingOrders.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsOrders");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ItemsOrders",
                columns: table => new
                {
                    ItemsItemId = table.Column<int>(type: "int", nullable: false),
                    OrdersShipperOrderId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsOrders", x => new { x.ItemsItemId, x.OrdersShipperOrderId });
                    table.ForeignKey(
                        name: "FK_ItemsOrders_Items_ItemsItemId",
                        column: x => x.ItemsItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemsOrders_Orders_OrdersShipperOrderId",
                        column: x => x.OrdersShipperOrderId,
                        principalTable: "Orders",
                        principalColumn: "ShipperOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsOrders_OrdersShipperOrderId",
                table: "ItemsOrders",
                column: "OrdersShipperOrderId");
        }
    }
}
