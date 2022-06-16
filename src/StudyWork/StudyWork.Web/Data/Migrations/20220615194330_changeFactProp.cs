using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudyWork.Web.Data.Migrations
{
    public partial class changeFactProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Facts_Content",
                table: "Facts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Facts_Content",
                table: "Facts",
                column: "Content");
        }
    }
}
