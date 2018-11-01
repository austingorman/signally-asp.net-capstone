using Microsoft.EntityFrameworkCore.Migrations;

namespace Signally.Migrations
{
    public partial class removedrequiredprice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9720010f-7830-4d0a-9527-03c2995f3ef8", "3a151bc6-5554-463c-948a-373b82c877ee" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "be9d416a-b78a-4b96-bc2e-53db372c274a", 0, "73419d35-f268-4100-9178-edba27bb1bf6", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELmB+2u7sY6YF+yKGmSptqMb5M6EXeDLsqgOLrrDHmX8UfUBzXDeEFmNar47Rnd8VA==", null, false, "6a6af2b6-3c11-4c0d-a50d-4c5d80aef5fa", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "be9d416a-b78a-4b96-bc2e-53db372c274a", "73419d35-f268-4100-9178-edba27bb1bf6" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9720010f-7830-4d0a-9527-03c2995f3ef8", 0, "3a151bc6-5554-463c-948a-373b82c877ee", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEMDzKVAq3BZa0xlqg47dbJ/GPRhdcUtquEyAJvT37jt57MsCz74fD3IEEsEbqXdiEA==", null, false, "22555f39-9a8f-4944-8d85-ab926de3299e", false, null });
        }
    }
}
