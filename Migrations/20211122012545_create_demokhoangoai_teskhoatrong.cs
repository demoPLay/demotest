using Microsoft.EntityFrameworkCore.Migrations;

namespace demotest.Migrations
{
    public partial class create_demokhoangoai_teskhoatrong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "teskhoatrong",
                columns: table => new
                {
                    teskhoatrongID = table.Column<string>(type: "TEXT", nullable: false),
                    teskhoatrongName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teskhoatrong", x => x.teskhoatrongID);
                });

            migrationBuilder.CreateTable(
                name: "demokhoangoai",
                columns: table => new
                {
                    demokhoangoaiID = table.Column<string>(type: "TEXT", nullable: false),
                    demokhoangoaiName = table.Column<string>(type: "TEXT", nullable: true),
                    UnitPrice = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<string>(type: "TEXT", nullable: true),
                    teskhoatrongID = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_demokhoangoai", x => x.demokhoangoaiID);
                    table.ForeignKey(
                        name: "FK_demokhoangoai_teskhoatrong_teskhoatrongID",
                        column: x => x.teskhoatrongID,
                        principalTable: "teskhoatrong",
                        principalColumn: "teskhoatrongID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_demokhoangoai_teskhoatrongID",
                table: "demokhoangoai",
                column: "teskhoatrongID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "demokhoangoai");

            migrationBuilder.DropTable(
                name: "teskhoatrong");
        }
    }
}
