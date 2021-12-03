using Microsoft.EntityFrameworkCore.Migrations;

namespace demotest.Migrations
{
    public partial class presonsedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "preson",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "preson");
        }
    }
}
