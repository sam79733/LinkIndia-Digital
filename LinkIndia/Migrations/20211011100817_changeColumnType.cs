using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LinkIndia.Migrations
{
    public partial class changeColumnType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Selfie",
                table: "transporterRegs",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(4000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pancard",
                table: "transporterRegs",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(4000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BusinessAddressProof",
                table: "transporterRegs",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(4000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressProof",
                table: "transporterRegs",
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
                table: "transporterRegs",
                type: "varbinary(4000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Pancard",
                table: "transporterRegs",
                type: "varbinary(4000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "BusinessAddressProof",
                table: "transporterRegs",
                type: "varbinary(4000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "AddressProof",
                table: "transporterRegs",
                type: "varbinary(4000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
