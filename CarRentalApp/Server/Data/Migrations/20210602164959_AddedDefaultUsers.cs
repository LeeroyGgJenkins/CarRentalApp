using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "654176FF-0BEB-431A-9A0A-2D0E4378EE9A",
                column: "ConcurrencyStamp",
                value: "e8e2487e-9965-4263-ab84-0fb4b7b6bbdd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A93DFAED-4AB6-4379-9239-7E9DD503A4F9",
                column: "ConcurrencyStamp",
                value: "e7e4915d-e68d-4963-b4d7-6166f95caccb");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2D7A5855-7973-4829-BC0D-80D1099F72D9", 0, "a7b04690-2c48-4d53-b365-095b298546a3", "admin@Localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAELqhXrRc8rBp3KJkOUk21DDcH5F6BDqqMIUF7XEiLIMLMLFV7G3H/KYFofzydHDmIg==", null, false, "c5c4df62-8cb8-4137-b396-920d27392931", false, "admin@localhost.com" },
                    { "78DCC559-D2D4-4741-82AB-501F81370AA5", 0, "a248e0e1-8780-4ac8-9382-d79d6457ff72", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKBD0OSgVs7RI/x3OHrqHfAYPAyCbGblklto5B/4sePqfEsTiXVv/g5D4neNcUMQjQ==", null, false, "89fe2d4e-9878-4259-86c4-19db42d96ac5", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 49, 58, 952, DateTimeKind.Local).AddTicks(4156), new DateTime(2021, 6, 2, 12, 49, 58, 954, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 49, 58, 955, DateTimeKind.Local).AddTicks(493), new DateTime(2021, 6, 2, 12, 49, 58, 955, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 49, 58, 956, DateTimeKind.Local).AddTicks(3031), new DateTime(2021, 6, 2, 12, 49, 58, 956, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 49, 58, 956, DateTimeKind.Local).AddTicks(3438), new DateTime(2021, 6, 2, 12, 49, 58, 956, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 49, 58, 956, DateTimeKind.Local).AddTicks(3453), new DateTime(2021, 6, 2, 12, 49, 58, 956, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 49, 58, 956, DateTimeKind.Local).AddTicks(7643), new DateTime(2021, 6, 2, 12, 49, 58, 956, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 49, 58, 956, DateTimeKind.Local).AddTicks(8285), new DateTime(2021, 6, 2, 12, 49, 58, 956, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 49, 58, 956, DateTimeKind.Local).AddTicks(8309), new DateTime(2021, 6, 2, 12, 49, 58, 956, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 12, 49, 58, 956, DateTimeKind.Local).AddTicks(8315), new DateTime(2021, 6, 2, 12, 49, 58, 956, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "A93DFAED-4AB6-4379-9239-7E9DD503A4F9", "2D7A5855-7973-4829-BC0D-80D1099F72D9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "654176FF-0BEB-431A-9A0A-2D0E4378EE9A", "78DCC559-D2D4-4741-82AB-501F81370AA5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "A93DFAED-4AB6-4379-9239-7E9DD503A4F9", "2D7A5855-7973-4829-BC0D-80D1099F72D9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "654176FF-0BEB-431A-9A0A-2D0E4378EE9A", "78DCC559-D2D4-4741-82AB-501F81370AA5" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2D7A5855-7973-4829-BC0D-80D1099F72D9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78DCC559-D2D4-4741-82AB-501F81370AA5");

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
    }
}
