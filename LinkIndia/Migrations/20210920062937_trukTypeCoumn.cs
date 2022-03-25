using Microsoft.EntityFrameworkCore.Migrations;

namespace LinkIndia.Migrations
{
    public partial class trukTypeCoumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TruckType",
                table: "postLoads",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TruckSubType",
                table: "postLoads",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TruckSubType",
                table: "postLoads");

            migrationBuilder.AlterColumn<string>(
                name: "TruckType",
                table: "postLoads",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
