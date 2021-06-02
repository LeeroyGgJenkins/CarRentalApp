using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Server.Data.Migrations
{
    public partial class SeededDefaultRoles4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "654176FF-0BEB-431A-9A0A-2D0E4378EE9A",
                column: "ConcurrencyStamp",
                value: "8daa3dca-8a86-4291-aac8-401955a213b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A93DFAED-4AB6-4379-9239-7E9DD503A4F9",
                column: "ConcurrencyStamp",
                value: "6df12701-3bc5-4334-b36c-fdfc309ebb5c");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 19, 46, 458, DateTimeKind.Local).AddTicks(3041), new DateTime(2021, 6, 2, 12, 19, 46, 461, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 19, 46, 461, DateTimeKind.Local).AddTicks(1279), new DateTime(2021, 6, 2, 12, 19, 46, 461, DateTimeKind.Local).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 19, 46, 462, DateTimeKind.Local).AddTicks(4354), new DateTime(2021, 6, 2, 12, 19, 46, 462, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 19, 46, 462, DateTimeKind.Local).AddTicks(4763), new DateTime(2021, 6, 2, 12, 19, 46, 462, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 19, 46, 462, DateTimeKind.Local).AddTicks(4779), new DateTime(2021, 6, 2, 12, 19, 46, 462, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 19, 46, 462, DateTimeKind.Local).AddTicks(8550), new DateTime(2021, 6, 2, 12, 19, 46, 462, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 19, 46, 462, DateTimeKind.Local).AddTicks(8955), new DateTime(2021, 6, 2, 12, 19, 46, 462, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 19, 46, 462, DateTimeKind.Local).AddTicks(8970), new DateTime(2021, 6, 2, 12, 19, 46, 462, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 19, 46, 462, DateTimeKind.Local).AddTicks(8975), new DateTime(2021, 6, 2, 12, 19, 46, 462, DateTimeKind.Local).AddTicks(8977) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "654176FF-0BEB-431A-9A0A-2D0E4378EE9A",
                column: "ConcurrencyStamp",
                value: "a32e4d8a-09b0-4869-832a-42e8ab996773");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A93DFAED-4AB6-4379-9239-7E9DD503A4F9",
                column: "ConcurrencyStamp",
                value: "5c0438a9-2a84-4ce4-818e-572c9b30815e");

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
    }
}
