using Microsoft.EntityFrameworkCore.Migrations;

namespace Product_Inventory.Migrations
{
    public partial class AddPersonNationality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Person",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Person");
        }
    }
}
