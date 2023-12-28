using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Vehicles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Models",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Makes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Colours",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Bookings",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "3899b5c9-1494-443c-b2a5-0a478ca381f5", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJmMvuyz81cnu/jqBAUystvErqay9PMcQTrhds41uXeWNlA2Rf9xI6J/EMntv1NIRA==", null, false, "fdf76b89-0289-4898-84e6-00d95a302ace", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(7757), new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(7779), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(7788), new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(7790), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(8766), new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(8769), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(8775), new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(8776), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(9408), new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(9411), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(9417), new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(9418), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(9422), new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(9424), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(9427), new DateTime(2023, 11, 24, 11, 14, 18, 611, DateTimeKind.Local).AddTicks(9429), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

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

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vehicles",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Models",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Makes",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Colours",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Bookings",
                newName: "ID");
        }
    }
}
