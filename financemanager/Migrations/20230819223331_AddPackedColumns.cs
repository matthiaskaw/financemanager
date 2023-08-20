using Microsoft.EntityFrameworkCore.Migrations;

namespace financemanager.Migrations
{
    public partial class AddPackedColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "order account",
                table: "VRTransaction",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "order account",
                table: "VRTransaction");
        }
    }
}
