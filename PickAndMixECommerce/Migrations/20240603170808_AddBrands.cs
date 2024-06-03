using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PickAndMixECommerce.Migrations
{
    /// <inheritdoc />
    public partial class AddBrands : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrandName",
                table: "Sweets");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Sweets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sweets_BrandId",
                table: "Sweets",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sweets_Brands_BrandId",
                table: "Sweets",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sweets_Brands_BrandId",
                table: "Sweets");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_Sweets_BrandId",
                table: "Sweets");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Sweets");

            migrationBuilder.AddColumn<string>(
                name: "BrandName",
                table: "Sweets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
