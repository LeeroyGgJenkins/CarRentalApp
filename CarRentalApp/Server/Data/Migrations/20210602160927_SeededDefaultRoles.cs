using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Server.Data.Migrations
{
    public partial class SeededDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "44694177-a021-4ce7-b71a-67784a17fc13", "f8e89036-a4f2-4307-8127-e5c1c1078c11", "User", "USER" },
                    { "55030ef5-ad9b-4181-b749-978875c8e14d", "0bbfeba6-4783-4b82-a0f7-e17ae375b8ad", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 9, 26, 709, DateTimeKind.Local).AddTicks(4413), new DateTime(2021, 6, 2, 12, 9, 26, 712, DateTimeKind.Local).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 9, 26, 712, DateTimeKind.Local).AddTicks(7192), new DateTime(2021, 6, 2, 12, 9, 26, 712, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 9, 26, 714, DateTimeKind.Local).AddTicks(3889), new DateTime(2021, 6, 2, 12, 9, 26, 714, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 9, 26, 714, DateTimeKind.Local).AddTicks(4321), new DateTime(2021, 6, 2, 12, 9, 26, 714, DateTimeKind.Local).AddTicks(4333) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 9, 26, 714, DateTimeKind.Local).AddTicks(4338), new DateTime(2021, 6, 2, 12, 9, 26, 714, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(4969), new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(4993), "Corolla", "System" },
                    { 2, "System", new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(5455), new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(5467), "Tercel", "System" },
                    { 3, "System", new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(5471), new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(5473), "M3", "System" },
                    { 4, "System", new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(5476), new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(5479), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44694177-a021-4ce7-b71a-67784a17fc13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55030ef5-ad9b-4181-b749-978875c8e14d");

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 0, 35, 411, DateTimeKind.Local).AddTicks(2186), new DateTime(2021, 6, 2, 12, 0, 35, 413, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 0, 35, 413, DateTimeKind.Local).AddTicks(9961), new DateTime(2021, 6, 2, 12, 0, 35, 413, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 0, 35, 415, DateTimeKind.Local).AddTicks(3152), new DateTime(2021, 6, 2, 12, 0, 35, 415, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 0, 35, 415, DateTimeKind.Local).AddTicks(3566), new DateTime(2021, 6, 2, 12, 0, 35, 415, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 0, 35, 415, DateTimeKind.Local).AddTicks(3581), new DateTime(2021, 6, 2, 12, 0, 35, 415, DateTimeKind.Local).AddTicks(3583) });
        }
    }
}
