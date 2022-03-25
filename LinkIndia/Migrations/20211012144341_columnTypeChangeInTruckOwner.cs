using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LinkIndia.Migrations
{
    public partial class columnTypeChangeInTruckOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransportName",
                table: "truckOwnerRegs");

            migrationBuilder.AlterColumn<string>(
                name: "Selfie",
                table: "truckOwnerRegs",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(4000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pancard",
                table: "truckOwnerRegs",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(4000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BusinessAddressProof",
                table: "truckOwnerRegs",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(4000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressProof",
                table: "truckOwnerRegs",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(4000)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Selfie",
                table: "truckOwnerRegs",
                type: "varbinary(4000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Pancard",
                table: "truckOwnerRegs",
                type: "varbinary(4000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "BusinessAddressProof",
                table: "truckOwnerRegs",
                type: "varbinary(4000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "AddressProof",
                table: "truckOwnerRegs",
                type: "varbinary(4000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransportName",
                table: "truckOwnerRegs",
                type: "text",
                nullable: true);
        }
    }
}
