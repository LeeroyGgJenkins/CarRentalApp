using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Server.Data.Migrations
{
    public partial class SeededDefaultRoles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44694177-a021-4ce7-b71a-67784a17fc13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55030ef5-ad9b-4181-b749-978875c8e14d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b8f4091-416f-4fd6-9659-9535217eab5b", "32957bef-16e3-4f8b-a543-67f1a583988f", "User", "USER" },
                    { "f176e7e0-413f-4f20-8e43-82c0b4c4931a", "f0aeea95-c680-45b4-9468-aa3f60ee3f0b", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 15, 43, 225, DateTimeKind.Local).AddTicks(8118), new DateTime(2021, 6, 2, 12, 15, 43, 228, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 15, 43, 228, DateTimeKind.Local).AddTicks(4270), new DateTime(2021, 6, 2, 12, 15, 43, 228, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 15, 43, 229, DateTimeKind.Local).AddTicks(6946), new DateTime(2021, 6, 2, 12, 15, 43, 229, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 15, 43, 229, DateTimeKind.Local).AddTicks(7365), new DateTime(2021, 6, 2, 12, 15, 43, 229, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 15, 43, 229, DateTimeKind.Local).AddTicks(7380), new DateTime(2021, 6, 2, 12, 15, 43, 229, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 15, 43, 230, DateTimeKind.Local).AddTicks(1081), new DateTime(2021, 6, 2, 12, 15, 43, 230, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 15, 43, 230, DateTimeKind.Local).AddTicks(1489), new DateTime(2021, 6, 2, 12, 15, 43, 230, DateTimeKind.Local).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 15, 43, 230, DateTimeKind.Local).AddTicks(1504), new DateTime(2021, 6, 2, 12, 15, 43, 230, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 15, 43, 230, DateTimeKind.Local).AddTicks(1510), new DateTime(2021, 6, 2, 12, 15, 43, 230, DateTimeKind.Local).AddTicks(1513) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b8f4091-416f-4fd6-9659-9535217eab5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f176e7e0-413f-4f20-8e43-82c0b4c4931a");

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

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(4969), new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(5455), new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(5471), new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(5476), new DateTime(2021, 6, 2, 12, 9, 26, 715, DateTimeKind.Local).AddTicks(5479) });
        }
    }
}
