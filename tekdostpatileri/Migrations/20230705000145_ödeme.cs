using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekdostpatileri.Migrations
{
    public partial class ödeme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ödemes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankaAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankaŞube = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankaŞehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    USD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EURO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ödemes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ödemes");
        }
    }
}
