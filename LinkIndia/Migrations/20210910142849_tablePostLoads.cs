using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace LinkIndia.Migrations
{
    public partial class tablePostLoads : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "postLoads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TruckCapacity = table.Column<string>(type: "text", nullable: true),
                    LoadFrom = table.Column<string>(type: "text", nullable: true),
                    LoadTo = table.Column<string>(type: "text", nullable: true),
                    TruckType = table.Column<string>(type: "text", nullable: true),
                    MaterialType = table.Column<string>(type: "text", nullable: true),
                    NumberOfTrucks = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Mobile = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postLoads", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "postLoads");
        }
    }
}
