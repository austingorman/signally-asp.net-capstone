using Microsoft.EntityFrameworkCore.Migrations;

namespace Signally.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4e7314d8-d3e3-4536-a969-edcb91f16ba7", "940821fc-295a-4fef-9e8f-02c96151ab46" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3d6ba3ae-9255-4dce-bf54-cbf144acde59", 0, "95824d0f-dad0-413e-b0da-35a579abebda", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELwJDS9O4j5rmE8Zt9So98ArpnhnSlSmi4JFLUS+DSa6vsR+/oxZxV8yRNIZk5YjdQ==", null, false, "bb4d7575-495c-4b25-a9a7-a4d94a814448", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3d6ba3ae-9255-4dce-bf54-cbf144acde59", "95824d0f-dad0-413e-b0da-35a579abebda" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4e7314d8-d3e3-4536-a969-edcb91f16ba7", 0, "940821fc-295a-4fef-9e8f-02c96151ab46", "FS110", false, false, null, null, null, "AQAAAAEAACcQAAAAEFe3x8K58G/NSTrK6+3I3eqMVUeNrAuKKvAr5u7U8HWVOnIr+ARREoya7GDx9iWdtA==", null, false, "833a95e4-23ab-4238-8a5c-33c93cfb3305", false, null });
        }
    }
}
