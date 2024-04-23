using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekdostpatileri.Migrations
{
    public partial class hakkında : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hakkındas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kurucuresmi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yazı1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yazı2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yazı3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yazı4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşimg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşunadı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşyazı1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşyazı2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşyazı3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşamacıp1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşamacıp2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşamacıyazı1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşamacıyazı2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşamacıyazı3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşamacıyazı4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşamacıyazı5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşamacıyazı6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşamacıyazı7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşamacıyazı8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşamacıyazı9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşamacıyazı10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kuruluşamacıyazı11 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hakkındas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hakkındas");
        }
    }
}
