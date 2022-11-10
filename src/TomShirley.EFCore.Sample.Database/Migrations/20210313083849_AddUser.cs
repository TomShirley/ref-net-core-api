using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TomShirley.EFCore.Sample.Database.Migrations
{
    public partial class AddUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OwnerUserId",
                table: "Blogs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_OwnerUserId",
                table: "Blogs",
                column: "OwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_User_OwnerUserId",
                table: "Blogs",
                column: "OwnerUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_User_OwnerUserId",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_OwnerUserId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "OwnerUserId",
                table: "Blogs");
        }
    }
}
