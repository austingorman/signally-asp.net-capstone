using Microsoft.EntityFrameworkCore.Migrations;

namespace Signally.Migrations
{
    public partial class removednullablebools : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f7d9639e-b38c-4bff-80ee-9c3476115f38", "f7d1c814-3dff-4e4e-9ad6-8f7c0ce7e03d" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7d4e922a-e906-412a-a31b-5ecbec66f221", 0, "d2790239-ded3-43a3-85c3-333a6c95961b", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEF4A0hzw0qvW/Ke4bRJnX9c+RruTwW10LluGa2Cjo64S8h0csEoSF06HGYcy+1pL9w==", null, false, "8af28d20-28e2-41ae-bdb7-dfee2ab4847e", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7d4e922a-e906-412a-a31b-5ecbec66f221", "d2790239-ded3-43a3-85c3-333a6c95961b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f7d9639e-b38c-4bff-80ee-9c3476115f38", 0, "f7d1c814-3dff-4e4e-9ad6-8f7c0ce7e03d", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEIyHinsP+GHDLR/EOoKFywJoHHkFHQY+60HkTw/b5RMZOSvcW9VDVf97Hr0+gZQmsg==", null, false, "b65bde22-7dca-4002-a401-ce7fbd768d2c", false, null });
        }
    }
}
