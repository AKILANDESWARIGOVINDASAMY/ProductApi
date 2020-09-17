using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductApi.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productdetails_Orderdetails_OrderId",
                table: "Productdetails");

            migrationBuilder.DropIndex(
                name: "IX_Productdetails_OrderId",
                table: "Productdetails");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Productdetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Productdetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productdetails_OrderId",
                table: "Productdetails",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productdetails_Orderdetails_OrderId",
                table: "Productdetails",
                column: "OrderId",
                principalTable: "Orderdetails",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
