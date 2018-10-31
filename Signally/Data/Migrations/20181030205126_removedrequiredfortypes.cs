using Microsoft.EntityFrameworkCore.Migrations;

namespace Signally.Migrations
{
    public partial class removedrequiredfortypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "90c2362c-9b05-436b-a204-7aa68fa68350", "3b49bca5-5c60-48be-9720-9ae2656e1231" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bb706ef7-a0ba-49a0-9b89-55155f4f20c0", 0, "ec0b0a91-2060-479a-8482-9f5c1efc84aa", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELQA2fmx+JJQKYpbU8Gusb+elvOe9p5DuvMUyFLdysaFq0KncEGDuGsd+X4WPI5Elw==", null, false, "dd64285f-47db-419b-af16-6c9e5257375c", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "bb706ef7-a0ba-49a0-9b89-55155f4f20c0", "ec0b0a91-2060-479a-8482-9f5c1efc84aa" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "90c2362c-9b05-436b-a204-7aa68fa68350", 0, "3b49bca5-5c60-48be-9720-9ae2656e1231", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEFnMnqzyDDGGida8GBR5PAr6ohWHdldgSLualqvzUGkwH2jptTqB/LcdywsJQ4DytA==", null, false, "516179f5-6b10-4fa7-9aca-f8de1a27972c", false, null });
        }
    }
}
