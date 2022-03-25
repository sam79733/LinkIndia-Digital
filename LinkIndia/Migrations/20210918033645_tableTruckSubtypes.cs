using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace LinkIndia.Migrations
{
    public partial class tableTruckSubtypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "trucksubTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SubType = table.Column<string>(type: "text", nullable: true),
                    TruckTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trucksubTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trucksubTypes_truckTypes_TruckTypeId",
                        column: x => x.TruckTypeId,
                        principalTable: "truckTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_trucksubTypes_TruckTypeId",
                table: "trucksubTypes",
                column: "TruckTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "trucksubTypes");
        }
    }
}
