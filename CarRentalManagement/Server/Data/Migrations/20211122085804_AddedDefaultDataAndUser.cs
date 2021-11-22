using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FristName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 22, 16, 58, 4, 295, DateTimeKind.Local).AddTicks(5411), new DateTime(2021, 11, 22, 16, 58, 4, 296, DateTimeKind.Local).AddTicks(7309), "Black", "System" },
                    { 2, "System", new DateTime(2021, 11, 22, 16, 58, 4, 296, DateTimeKind.Local).AddTicks(8618), new DateTime(2021, 11, 22, 16, 58, 4, 296, DateTimeKind.Local).AddTicks(8625), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 22, 16, 58, 4, 304, DateTimeKind.Local).AddTicks(8128), new DateTime(2021, 11, 22, 16, 58, 4, 304, DateTimeKind.Local).AddTicks(8139), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 11, 22, 16, 58, 4, 304, DateTimeKind.Local).AddTicks(8143), new DateTime(2021, 11, 22, 16, 58, 4, 304, DateTimeKind.Local).AddTicks(8144), "Mitsubishi", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 22, 16, 58, 4, 302, DateTimeKind.Local).AddTicks(5742), new DateTime(2021, 11, 22, 16, 58, 4, 302, DateTimeKind.Local).AddTicks(5760), "A31", "System" },
                    { 2, "System", new DateTime(2021, 11, 22, 16, 58, 4, 302, DateTimeKind.Local).AddTicks(5764), new DateTime(2021, 11, 22, 16, 58, 4, 302, DateTimeKind.Local).AddTicks(5765), "A32", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "LastName",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FristName",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
