using Microsoft.EntityFrameworkCore.Migrations;

namespace Signally.Migrations
{
    public partial class addedkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "089d1d18-bb67-4b5c-8ed1-6399cedf8413", "6b6fa8c4-e288-44b8-bd8e-87f5d5b279e1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c6b0cb94-ae26-4b77-9091-46b45e3699f4", 0, "f16b2663-fc85-460d-abc8-d666e8622ae5", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEAEzgFI0r2yQLjWaFvG293DRFXEk2V42aVbY+GY1eQJFSVQhR6bbD/H4Nmkc8EP/ag==", null, false, "0c7b7ab2-48ed-4761-92a4-4fd2a66ef505", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c6b0cb94-ae26-4b77-9091-46b45e3699f4", "f16b2663-fc85-460d-abc8-d666e8622ae5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "089d1d18-bb67-4b5c-8ed1-6399cedf8413", 0, "6b6fa8c4-e288-44b8-bd8e-87f5d5b279e1", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEADZmKIU72SOdaQkA03h9i/o+ADowTxksh6iyedEeARfs9eZf2lDLEteap+ii6SJrg==", null, false, "08a0162a-b700-47f5-a6c1-c4828ac8eb44", false, null });
        }
    }
}
