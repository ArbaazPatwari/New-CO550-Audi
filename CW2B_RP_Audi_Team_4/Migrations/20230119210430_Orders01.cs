using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW2B_RP_Audi_Team_4.Migrations
{
    public partial class Orders01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TableNumber = table.Column<int>(type: "int", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Confirmation = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DeliveryDate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DeliveryTracking = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
