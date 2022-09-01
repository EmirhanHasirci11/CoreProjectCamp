using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class _Author_Blog_Relations_Declared_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuthorID",
                table: "Blogs",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Authors_AuthorID",
                table: "Blogs",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Authors_AuthorID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_AuthorID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "Blogs");
        }
    }
}
