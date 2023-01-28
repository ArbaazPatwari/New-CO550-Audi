using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW2B_RP_Audi_Team_4.Migrations
{
    public partial class AddCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Order_OrderID",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_OrderItem_OrderItemCarID",
                table: "Car");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Car_OrderID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_OrderItemCarID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "OrderItemCarID",
                table: "Car");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderItemCarID",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Confirmation = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DeliveryDate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DeliveryTracking = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TableNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.CarID);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_OrderID",
                table: "Car",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_OrderItemCarID",
                table: "Car",
                column: "OrderItemCarID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Order_OrderID",
                table: "Car",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_OrderItem_OrderItemCarID",
                table: "Car",
                column: "OrderItemCarID",
                principalTable: "OrderItem",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
