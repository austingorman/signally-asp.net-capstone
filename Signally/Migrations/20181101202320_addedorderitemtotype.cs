using Microsoft.EntityFrameworkCore.Migrations;

namespace Signally.Migrations
{
    public partial class addedorderitemtotype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "be9d416a-b78a-4b96-bc2e-53db372c274a", "73419d35-f268-4100-9178-edba27bb1bf6" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "39309eab-264b-4907-95c7-063286a6175e", 0, "ff8355de-1c0e-4f13-92a2-5e192ce8fe2c", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEGLBcmBBEN2ffrdJGREJ2hPNbDT0hvcxI0Idi+6JFZtle7+GaaGB2uxFG3CqhZwBfw==", null, false, "de172957-5ea4-40e8-9ca4-defaa2c866b9", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "39309eab-264b-4907-95c7-063286a6175e", "ff8355de-1c0e-4f13-92a2-5e192ce8fe2c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "be9d416a-b78a-4b96-bc2e-53db372c274a", 0, "73419d35-f268-4100-9178-edba27bb1bf6", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELmB+2u7sY6YF+yKGmSptqMb5M6EXeDLsqgOLrrDHmX8UfUBzXDeEFmNar47Rnd8VA==", null, false, "6a6af2b6-3c11-4c0d-a50d-4c5d80aef5fa", false, null });
        }
    }
}
