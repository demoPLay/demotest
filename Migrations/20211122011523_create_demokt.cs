using Microsoft.EntityFrameworkCore.Migrations;

namespace demotest.Migrations
{
    public partial class create_demokt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Student",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "demoktID",
                table: "Student",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "demoktName",
                table: "Student",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "demoktID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "demoktName",
                table: "Student");
        }
    }
}
