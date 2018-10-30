using Microsoft.EntityFrameworkCore.Migrations;

namespace Signally.Migrations
{
    public partial class phonestring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3d6ba3ae-9255-4dce-bf54-cbf144acde59", "95824d0f-dad0-413e-b0da-35a579abebda" });

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "83718ecb-7540-407d-9d26-f9469ff67fe1", 0, "eda654c8-a432-492e-9430-7de3f0e9f802", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEE1MxoNS90D4kVJgkzPRzahzR8GgbZSz3KWbEOXLpPjb6XE+KoWep5hr5elIuNFgOA==", null, false, "883aace0-bba7-4311-b185-e7ffaa0d794f", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "83718ecb-7540-407d-9d26-f9469ff67fe1", "eda654c8-a432-492e-9430-7de3f0e9f802" });

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3d6ba3ae-9255-4dce-bf54-cbf144acde59", 0, "95824d0f-dad0-413e-b0da-35a579abebda", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELwJDS9O4j5rmE8Zt9So98ArpnhnSlSmi4JFLUS+DSa6vsR+/oxZxV8yRNIZk5YjdQ==", null, false, "bb4d7575-495c-4b25-a9a7-a4d94a814448", false, null });
        }
    }
}
