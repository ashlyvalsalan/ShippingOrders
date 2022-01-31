using Microsoft.EntityFrameworkCore.Migrations;

namespace ShippingOrders.Migrations
{
    public partial class migration19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Items_ItemCode",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ItemCode",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ItemCode",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemCode",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ItemCode",
                table: "Orders",
                column: "ItemCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Items_ItemCode",
                table: "Orders",
                column: "ItemCode",
                principalTable: "Items",
                principalColumn: "ItemCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
