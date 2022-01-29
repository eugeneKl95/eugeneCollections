using Microsoft.EntityFrameworkCore.Migrations;

namespace eugeneCollections.Migrations
{
    public partial class updata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "453a9142b-6d96-44fe-b817-982b5528f922",
                column: "ConcurrencyStamp",
                value: "5b45e4cb-1867-459f-9e45-77fff4c228a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69fc5637-63fd-43e7-8e50-66ede650df4c",
                column: "ConcurrencyStamp",
                value: "88928a52-c936-426c-988e-d9801893dd7a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e7260d4-1372-412d-aadb-061d53bb1ec3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78a52c60-591f-42ad-9fe9-aabcac8889ee", "AQAAAAEAACcQAAAAENUd7dFa6lXB0jNIc8Dxnf/R1qpwXJqIO3i3HTtl5kWSDpXF0H8OznPythlqW9y+JQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "453a9142b-6d96-44fe-b817-982b5528f922",
                column: "ConcurrencyStamp",
                value: "31d088fe-c688-44b8-8874-dab610712a17");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69fc5637-63fd-43e7-8e50-66ede650df4c",
                column: "ConcurrencyStamp",
                value: "e7e3236a-3dd2-4610-bc8d-9effab210d78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e7260d4-1372-412d-aadb-061d53bb1ec3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "daca6aa8-ab91-40df-8edb-6bf1275de61d", "AQAAAAEAACcQAAAAEGRz/EfuBxmy6DyvDKOke78WSN+q47MJ4r7XNn3Dm8yRtlX8VYvTa7KIH5s5YOoJtQ==" });
        }
    }
}
