using Microsoft.EntityFrameworkCore.Migrations;

namespace demotest.Migrations
{
    public partial class great_table_category_product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "categoryID",
                table: "Product",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PersonName",
                table: "person",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "categorys",
                columns: table => new
                {
                    categoryID = table.Column<string>(type: "TEXT", nullable: false),
                    categoryName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorys", x => x.categoryID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_categoryID",
                table: "Product",
                column: "categoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_categorys_categoryID",
                table: "Product",
                column: "categoryID",
                principalTable: "categorys",
                principalColumn: "categoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_categorys_categoryID",
                table: "Product");

            migrationBuilder.DropTable(
                name: "categorys");

            migrationBuilder.DropIndex(
                name: "IX_Product_categoryID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "categoryID",
                table: "Product");

            migrationBuilder.AlterColumn<decimal>(
                name: "PersonName",
                table: "person",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
