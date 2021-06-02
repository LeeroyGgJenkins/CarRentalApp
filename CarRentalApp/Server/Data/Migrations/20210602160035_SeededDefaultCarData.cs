using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 6, 2, 12, 0, 35, 411, DateTimeKind.Local).AddTicks(2186), new DateTime(2021, 6, 2, 12, 0, 35, 413, DateTimeKind.Local).AddTicks(8822), "Black", "System" },
                    { 2, "System", new DateTime(2021, 6, 2, 12, 0, 35, 413, DateTimeKind.Local).AddTicks(9961), new DateTime(2021, 6, 2, 12, 0, 35, 413, DateTimeKind.Local).AddTicks(9974), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 6, 2, 12, 0, 35, 415, DateTimeKind.Local).AddTicks(3152), new DateTime(2021, 6, 2, 12, 0, 35, 415, DateTimeKind.Local).AddTicks(3172), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 6, 2, 12, 0, 35, 415, DateTimeKind.Local).AddTicks(3566), new DateTime(2021, 6, 2, 12, 0, 35, 415, DateTimeKind.Local).AddTicks(3577), "BMW", "System" },
                    { 3, "System", new DateTime(2021, 6, 2, 12, 0, 35, 415, DateTimeKind.Local).AddTicks(3581), new DateTime(2021, 6, 2, 12, 0, 35, 415, DateTimeKind.Local).AddTicks(3583), "Subaru", "System" }
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
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
