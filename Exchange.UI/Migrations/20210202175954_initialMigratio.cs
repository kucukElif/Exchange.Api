using Microsoft.EntityFrameworkCore.Migrations;

namespace Exchange.UI.Migrations
{
    public partial class initialMigratio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CurrencyModels",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrossRateUsd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForexBuying = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ForexSelling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankNoteBuying = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanknoteSelling = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyModels", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrencyModels");
        }
    }
}
