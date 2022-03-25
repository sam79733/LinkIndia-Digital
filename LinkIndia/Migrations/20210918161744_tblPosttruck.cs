using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace LinkIndia.Migrations
{
    public partial class tblPosttruck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "postTrucks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    OwnerName = table.Column<string>(type: "text", nullable: true),
                    Mobile = table.Column<string>(type: "text", nullable: true),
                    TruckTypeId = table.Column<int>(type: "int", nullable: false),
                    TruckSubTypeId = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "text", nullable: true),
                    VehicleNumber = table.Column<string>(type: "text", nullable: true),
                    RouteFrom = table.Column<string>(type: "text", nullable: true),
                    AddharNumber = table.Column<string>(type: "text", nullable: true),
                    RCFront = table.Column<byte[]>(type: "varbinary(4000)", nullable: true),
                    RCBack = table.Column<byte[]>(type: "varbinary(4000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postTrucks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "postTrucks");
        }
    }
}
