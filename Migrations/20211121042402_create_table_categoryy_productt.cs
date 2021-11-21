using Microsoft.EntityFrameworkCore.Migrations;

namespace demotest.Migrations
{
    public partial class create_table_categoryy_productt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoryss",
                columns: table => new
                {
                    categoryyID = table.Column<string>(type: "TEXT", nullable: false),
                    categoryyName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryss", x => x.categoryyID);
                });

            migrationBuilder.CreateTable(
                name: "Productt",
                columns: table => new
                {
                    ProducttID = table.Column<string>(type: "TEXT", nullable: false),
                    ProducttName = table.Column<string>(type: "TEXT", nullable: true),
                    UnitPrice = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<string>(type: "TEXT", nullable: true),
                    categoryyID = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productt", x => x.ProducttID);
                    table.ForeignKey(
                        name: "FK_Productt_categoryss_categoryyID",
                        column: x => x.categoryyID,
                        principalTable: "categoryss",
                        principalColumn: "categoryyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productt_categoryyID",
                table: "Productt",
                column: "categoryyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productt");

            migrationBuilder.DropTable(
                name: "categoryss");
        }
    }
}
