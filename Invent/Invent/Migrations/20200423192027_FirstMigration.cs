using Microsoft.EntityFrameworkCore.Migrations;

namespace Invent.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shopkeeper",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: false),
                    ProductPrice = table.Column<string>(nullable: false),
                    Quantity = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopkeeper", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Shopkeeper",
                columns: new[] { "ProductId", "Date", "ProductName", "ProductPrice", "Quantity" },
                values: new object[] { 1, "22/04/2020", "Usha Celling Fan", "550", "10" });

            migrationBuilder.InsertData(
                table: "Shopkeeper",
                columns: new[] { "ProductId", "Date", "ProductName", "ProductPrice", "Quantity" },
                values: new object[] { 2, "22/04/2020", "Usha Mixer Grinder", "800", "10" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shopkeeper");
        }
    }
}
