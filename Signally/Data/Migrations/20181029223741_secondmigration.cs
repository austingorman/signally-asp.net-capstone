using Microsoft.EntityFrameworkCore.Migrations;

namespace Signally.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c03ec030-ae06-4ce0-806b-5cd5860928b1", "39ea71b6-1cde-4844-a873-7cd8f46cb5d5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4e7314d8-d3e3-4536-a969-edcb91f16ba7", 0, "940821fc-295a-4fef-9e8f-02c96151ab46", "FS110", false, false, null, null, null, "AQAAAAEAACcQAAAAEFe3x8K58G/NSTrK6+3I3eqMVUeNrAuKKvAr5u7U8HWVOnIr+ARREoya7GDx9iWdtA==", null, false, "833a95e4-23ab-4238-8a5c-33c93cfb3305", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4e7314d8-d3e3-4536-a969-edcb91f16ba7", "940821fc-295a-4fef-9e8f-02c96151ab46" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c03ec030-ae06-4ce0-806b-5cd5860928b1", 0, "39ea71b6-1cde-4844-a873-7cd8f46cb5d5", null, false, false, null, null, null, "AQAAAAEAACcQAAAAEEVOzBVjATIFAw7489R9jWU0oEDiIjPA5rnUqrj9Lmo+grPeC9Svmwk8hcCdOJqI/A==", null, false, "2d20b6b5-c895-4c94-814b-3f3dfe1bbcef", false, "FS110" });
        }
    }
}
