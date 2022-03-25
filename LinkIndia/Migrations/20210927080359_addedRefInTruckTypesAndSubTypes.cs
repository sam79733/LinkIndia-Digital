using Microsoft.EntityFrameworkCore.Migrations;

namespace LinkIndia.Migrations
{
    public partial class addedRefInTruckTypesAndSubTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trucksubTypes_truckTypes_TruckTypeId",
                table: "trucksubTypes");

            migrationBuilder.AlterColumn<int>(
                name: "TruckTypeId",
                table: "trucksubTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_trucksubTypes_truckTypes_TruckTypeId",
                table: "trucksubTypes",
                column: "TruckTypeId",
                principalTable: "truckTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trucksubTypes_truckTypes_TruckTypeId",
                table: "trucksubTypes");

            migrationBuilder.AlterColumn<int>(
                name: "TruckTypeId",
                table: "trucksubTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_trucksubTypes_truckTypes_TruckTypeId",
                table: "trucksubTypes",
                column: "TruckTypeId",
                principalTable: "truckTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
