using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Server.Data.Migrations
{
    public partial class SeededDefaultRoles3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "654176FF-0BEB-431A-9A0A-2D0E4378EE9A", "a32e4d8a-09b0-4869-832a-42e8ab996773", "User", "USER" },
                    { "A93DFAED-4AB6-4379-9239-7E9DD503A4F9", "5c0438a9-2a84-4ce4-818e-572c9b30815e", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 18, 42, 715, DateTimeKind.Local).AddTicks(3790), new DateTime(2021, 6, 2, 12, 18, 42, 717, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 18, 42, 718, DateTimeKind.Local).AddTicks(857), new DateTime(2021, 6, 2, 12, 18, 42, 718, DateTimeKind.Local).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 18, 42, 719, DateTimeKind.Local).AddTicks(3526), new DateTime(2021, 6, 2, 12, 18, 42, 719, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 18, 42, 719, DateTimeKind.Local).AddTicks(3938), new DateTime(2021, 6, 2, 12, 18, 42, 719, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 18, 42, 719, DateTimeKind.Local).AddTicks(3953), new DateTime(2021, 6, 2, 12, 18, 42, 719, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 18, 42, 719, DateTimeKind.Local).AddTicks(7661), new DateTime(2021, 6, 2, 12, 18, 42, 719, DateTimeKind.Local).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 18, 42, 719, DateTimeKind.Local).AddTicks(8065), new DateTime(2021, 6, 2, 12, 18, 42, 719, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 18, 42, 719, DateTimeKind.Local).AddTicks(8080), new DateTime(2021, 6, 2, 12, 18, 42, 719, DateTimeKind.Local).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 18, 42, 719, DateTimeKind.Local).AddTicks(8085), new DateTime(2021, 6, 2, 12, 18, 42, 719, DateTimeKind.Local).AddTicks(8088) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "654176FF-0BEB-431A-9A0A-2D0E4378EE9A");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A93DFAED-4AB6-4379-9239-7E9DD503A4F9");

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
    }
}
