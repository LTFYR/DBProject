using Microsoft.EntityFrameworkCore.Migrations;

namespace DBProject.Migrations
{
    public partial class addedCommentstoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Blogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Blogs");
        }
    }
}
