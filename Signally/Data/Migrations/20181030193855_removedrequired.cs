using Microsoft.EntityFrameworkCore.Migrations;

namespace Signally.Migrations
{
    public partial class removedrequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ac4bc711-84e7-4bdf-9337-bfcaa45279f6", "e2154288-06e4-4030-b543-83e24c78f312" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "820f2a13-0a5d-4ed5-931f-0619026b028a", 0, "5ea6993f-16e3-4185-9fa9-b930fa0b2c05", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEGaeocmawOd2zROsFzoAH+T3+7ta8Zq8rJ3BfAYuXvlcbEgtjLA5F5DJel5gpFVuZw==", null, false, "193f6785-f9e3-485d-9a1b-75fce7bef905", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "820f2a13-0a5d-4ed5-931f-0619026b028a", "5ea6993f-16e3-4185-9fa9-b930fa0b2c05" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ac4bc711-84e7-4bdf-9337-bfcaa45279f6", 0, "e2154288-06e4-4030-b543-83e24c78f312", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAECCMNG6CfGsgNuOsi7iVxItZtMYGdgNzsl/MwqZDg+oUrIV3/fusmqlk4DEzCT1niw==", null, false, "6d7bc8c0-b19e-4c80-9137-156840ed3653", false, null });
        }
    }
}
