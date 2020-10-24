using Microsoft.EntityFrameworkCore.Migrations;

namespace Product_Inventory.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    DOB = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Age = table.Column<string>(unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    Gender = table.Column<string>(unicode: false, fixedLength: true, maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Category = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Color = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    AvailableQuantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Products__B40CC6CD5A75D91F", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
