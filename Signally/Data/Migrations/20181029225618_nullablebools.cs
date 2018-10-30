using Microsoft.EntityFrameworkCore.Migrations;

namespace Signally.Migrations
{
    public partial class nullablebools : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "83718ecb-7540-407d-9d26-f9469ff67fe1", "eda654c8-a432-492e-9430-7de3f0e9f802" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f7d9639e-b38c-4bff-80ee-9c3476115f38", 0, "f7d1c814-3dff-4e4e-9ad6-8f7c0ce7e03d", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEIyHinsP+GHDLR/EOoKFywJoHHkFHQY+60HkTw/b5RMZOSvcW9VDVf97Hr0+gZQmsg==", null, false, "b65bde22-7dca-4002-a401-ce7fbd768d2c", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f7d9639e-b38c-4bff-80ee-9c3476115f38", "f7d1c814-3dff-4e4e-9ad6-8f7c0ce7e03d" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "83718ecb-7540-407d-9d26-f9469ff67fe1", 0, "eda654c8-a432-492e-9430-7de3f0e9f802", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEE1MxoNS90D4kVJgkzPRzahzR8GgbZSz3KWbEOXLpPjb6XE+KoWep5hr5elIuNFgOA==", null, false, "883aace0-bba7-4311-b185-e7ffaa0d794f", false, null });
        }
    }
}
