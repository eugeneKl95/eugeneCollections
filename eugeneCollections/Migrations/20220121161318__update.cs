using Microsoft.EntityFrameworkCore.Migrations;

namespace eugeneCollections.Migrations
{
    public partial class _update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Collections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PathImg",
                table: "Collections",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "453a9142b-6d96-44fe-b817-982b5528f922",
                column: "ConcurrencyStamp",
                value: "6e119571-3b9d-4e55-a722-7da8f9074571");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69fc5637-63fd-43e7-8e50-66ede650df4c",
                column: "ConcurrencyStamp",
                value: "32d40ded-5e1e-468d-98c5-04c3f7121c5c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e7260d4-1372-412d-aadb-061d53bb1ec3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6fdb6ef7-59f3-4af4-9dcf-62b682f036e9", "AQAAAAEAACcQAAAAEAI7Sjh0FQM9c6miC8v10gI27vQqDtwHcxLE7pF1g/CZCpSVfUaNpMOeP0Xm+NchaA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "PathImg",
                table: "Collections");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "453a9142b-6d96-44fe-b817-982b5528f922",
                column: "ConcurrencyStamp",
                value: "1033b06d-2815-4c8a-99d4-8defaca5b000");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69fc5637-63fd-43e7-8e50-66ede650df4c",
                column: "ConcurrencyStamp",
                value: "9f51f22e-43d8-4886-a320-f1f242b2d231");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e7260d4-1372-412d-aadb-061d53bb1ec3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "43e072a1-ee5e-483b-85bd-88cc113d8e6f", "AQAAAAEAACcQAAAAEI/ZcguY9R1M14FO11vlpmCKQ1/lvnYc/mgiHK9iXrv0kIl837T/ElXctXAfrIE1Iw==" });
        }
    }
}
