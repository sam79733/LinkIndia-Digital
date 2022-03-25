using Microsoft.EntityFrameworkCore.Migrations;

namespace LinkIndia.Migrations
{
    public partial class addedonemorecolumninposttruck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RouteTo",
                table: "postTrucks",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RouteTo",
                table: "postTrucks");
        }
    }
}
