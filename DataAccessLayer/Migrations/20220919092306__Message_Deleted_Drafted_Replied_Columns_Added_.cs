using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class _Message_Deleted_Drafted_Replied_Columns_Added_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Message2s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeletedConfirm",
                table: "Message2s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDrafted",
                table: "Message2s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RepliedTo",
                table: "Message2s",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Message2s");

            migrationBuilder.DropColumn(
                name: "IsDeletedConfirm",
                table: "Message2s");

            migrationBuilder.DropColumn(
                name: "IsDrafted",
                table: "Message2s");

            migrationBuilder.DropColumn(
                name: "RepliedTo",
                table: "Message2s");
        }
    }
}
