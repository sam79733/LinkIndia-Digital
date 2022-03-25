using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace LinkIndia.Migrations
{
    public partial class InitiateCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "client_LoadRegs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Mobile = table.Column<string>(type: "text", nullable: true),
                    TransportName = table.Column<string>(type: "text", nullable: true),
                    BusinessAddressProof = table.Column<byte[]>(type: "varbinary(4000)", nullable: true),
                    Add_Line1 = table.Column<string>(type: "text", nullable: true),
                    Add_Line2 = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    AddressProof = table.Column<byte[]>(type: "varbinary(4000)", nullable: true),
                    Selfie = table.Column<byte[]>(type: "varbinary(4000)", nullable: true),
                    Pancard = table.Column<byte[]>(type: "varbinary(4000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_LoadRegs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "truckOwnerRegs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Mobile = table.Column<string>(type: "text", nullable: true),
                    TransportName = table.Column<string>(type: "text", nullable: true),
                    BusinessAddressProof = table.Column<byte[]>(type: "varbinary(4000)", nullable: true),
                    Add_Line1 = table.Column<string>(type: "text", nullable: true),
                    Add_Line2 = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    AddressProof = table.Column<byte[]>(type: "varbinary(4000)", nullable: true),
                    Selfie = table.Column<byte[]>(type: "varbinary(4000)", nullable: true),
                    Pancard = table.Column<byte[]>(type: "varbinary(4000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_truckOwnerRegs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "client_LoadRegs");

            migrationBuilder.DropTable(
                name: "truckOwnerRegs");
        }
    }
}
