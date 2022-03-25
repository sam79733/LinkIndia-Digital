using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LinkIndia.Migrations
{
    public partial class Column_dataTypeChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RCFront",
                table: "postTrucks",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(4000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RCBack",
                table: "postTrucks",
                type: "text",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(4000)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "RCFront",
                table: "postTrucks",
                type: "varbinary(4000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RCBack",
                table: "postTrucks",
                type: "varbinary(4000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
