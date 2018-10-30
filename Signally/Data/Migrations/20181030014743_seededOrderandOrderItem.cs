using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Signally.Migrations
{
    public partial class seededOrderandOrderItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4b336f42-af40-4b34-9dae-53827baaf1c5", "35b13e71-edc1-455e-819d-5d005881f850" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ac4bc711-84e7-4bdf-9337-bfcaa45279f6", 0, "e2154288-06e4-4030-b543-83e24c78f312", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAECCMNG6CfGsgNuOsi7iVxItZtMYGdgNzsl/MwqZDg+oUrIV3/fusmqlk4DEzCT1niw==", null, false, "6d7bc8c0-b19e-4c80-9137-156840ed3653", false, null });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "CSRId", "CustomerId", "DateDue", "DatePlaced", "Install", "Price", "Rush", "StatusId" },
                values: new object[] { 1, 1, 2, new DateTime(2018, 10, 31, 10, 56, 20, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 17, 13, 56, 25, 0, DateTimeKind.Unspecified), false, 100.0, true, 1 });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "OrderItemId", "Height", "OrderId", "Price", "Quantity", "TypeId", "Width" },
                values: new object[] { 1, 18, 1, 22.5, 1, 3, 12 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ac4bc711-84e7-4bdf-9337-bfcaa45279f6", "e2154288-06e4-4030-b543-83e24c78f312" });

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "OrderItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4b336f42-af40-4b34-9dae-53827baaf1c5", 0, "35b13e71-edc1-455e-819d-5d005881f850", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEPyzP/3Ps1BGHcM2Tlguez2uxVhLJHEHIigFL5fBG2OoWyRQgaKdqkGclY0QGY4xnQ==", null, false, "364ff48b-f28c-4cad-b58d-661422205de3", false, null });
        }
    }
}
