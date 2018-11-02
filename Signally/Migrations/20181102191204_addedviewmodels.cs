using Microsoft.EntityFrameworkCore.Migrations;

namespace Signally.Migrations
{
    public partial class addedviewmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c6b0cb94-ae26-4b77-9091-46b45e3699f4", "f16b2663-fc85-460d-abc8-d666e8622ae5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e7216593-b757-4bed-8fd3-923f5bdc16dd", 0, "915dca33-e082-4f82-ac9d-c81e006c9518", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEJfXWnNSaV5nVgT3ONGBC7HHpfWstWlSulKNSYTRoiibndkCJQT/IYvw6Gqe4W7Hww==", null, false, "53b6158a-2a91-4af7-8a42-60a404742e89", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e7216593-b757-4bed-8fd3-923f5bdc16dd", "915dca33-e082-4f82-ac9d-c81e006c9518" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c6b0cb94-ae26-4b77-9091-46b45e3699f4", 0, "f16b2663-fc85-460d-abc8-d666e8622ae5", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEAEzgFI0r2yQLjWaFvG293DRFXEk2V42aVbY+GY1eQJFSVQhR6bbD/H4Nmkc8EP/ag==", null, false, "0c7b7ab2-48ed-4761-92a4-4fd2a66ef505", false, null });
        }
    }
}
