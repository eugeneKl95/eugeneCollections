using Microsoft.EntityFrameworkCore.Migrations;

namespace eugeneCollections.Migrations
{
    public partial class _update2401 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Items_ItemId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Items_ItemId",
                table: "Tags");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Tags_ItemId",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Likes",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ItemId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "CollectionId",
                table: "Tags",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CollectiionId",
                table: "Likes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CollectionId",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Likes",
                table: "Likes",
                columns: new[] { "UserId", "CollectiionId" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Tags_CollectionId",
                table: "Tags",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CollectionId",
                table: "Comments",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Collections_ThemeId",
                table: "Collections",
                column: "ThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collections_Themes_ThemeId",
                table: "Collections",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Collections_CollectionId",
                table: "Comments",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Collections_CollectionId",
                table: "Tags",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collections_Themes_ThemeId",
                table: "Collections");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Collections_CollectionId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Collections_CollectionId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_CollectionId",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Likes",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CollectionId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Collections_ThemeId",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "CollectionId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "CollectiionId",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "CollectionId",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Tags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Likes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Likes",
                table: "Likes",
                columns: new[] { "UserId", "ItemId" });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollectionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Tags_ItemId",
                table: "Tags",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ItemId",
                table: "Comments",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Items_ItemId",
                table: "Comments",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Items_ItemId",
                table: "Tags",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
