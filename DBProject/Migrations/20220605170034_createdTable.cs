using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBProject.Migrations
{
    public partial class createdTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "BlockQuote",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Blogs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Blogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlockQuote",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
