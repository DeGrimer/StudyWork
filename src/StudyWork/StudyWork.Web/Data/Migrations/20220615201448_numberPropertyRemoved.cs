using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudyWork.Web.Data.Migrations
{
    public partial class numberPropertyRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Facts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Tags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Facts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
