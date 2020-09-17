using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductApi.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Productdetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Orderdetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productdetails_OrderId",
                table: "Productdetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orderdetails_CustomerId",
                table: "Orderdetails",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderdetails_Customerdetails_CustomerId",
                table: "Orderdetails",
                column: "CustomerId",
                principalTable: "Customerdetails",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Productdetails_Orderdetails_OrderId",
                table: "Productdetails",
                column: "OrderId",
                principalTable: "Orderdetails",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderdetails_Customerdetails_CustomerId",
                table: "Orderdetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Productdetails_Orderdetails_OrderId",
                table: "Productdetails");

            migrationBuilder.DropIndex(
                name: "IX_Productdetails_OrderId",
                table: "Productdetails");

            migrationBuilder.DropIndex(
                name: "IX_Orderdetails_CustomerId",
                table: "Orderdetails");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Productdetails");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Orderdetails");
        }
    }
}
