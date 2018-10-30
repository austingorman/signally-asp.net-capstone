using Microsoft.EntityFrameworkCore.Migrations;

namespace Signally.Migrations
{
    public partial class addeddisplaynames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7d4e922a-e906-412a-a31b-5ecbec66f221", "d2790239-ded3-43a3-85c3-333a6c95961b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4b336f42-af40-4b34-9dae-53827baaf1c5", 0, "35b13e71-edc1-455e-819d-5d005881f850", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEPyzP/3Ps1BGHcM2Tlguez2uxVhLJHEHIigFL5fBG2OoWyRQgaKdqkGclY0QGY4xnQ==", null, false, "364ff48b-f28c-4cad-b58d-661422205de3", false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4b336f42-af40-4b34-9dae-53827baaf1c5", "35b13e71-edc1-455e-819d-5d005881f850" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7d4e922a-e906-412a-a31b-5ecbec66f221", 0, "d2790239-ded3-43a3-85c3-333a6c95961b", "110@signs.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEF4A0hzw0qvW/Ke4bRJnX9c+RruTwW10LluGa2Cjo64S8h0csEoSF06HGYcy+1pL9w==", null, false, "8af28d20-28e2-41ae-bdb7-dfee2ab4847e", false, null });
        }
    }
}
