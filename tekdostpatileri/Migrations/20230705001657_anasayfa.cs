using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekdostpatileri.Migrations
{
    public partial class anasayfa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "anasayfas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    slider1başlık = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slider1yazı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slider2başlık = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slider2yazı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slider3başlık = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slider3yazı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slider4başlık = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slider4yazı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slider5başlık = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slider5yazı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slider1img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slider2img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slider3img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slider4img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slider5img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    önsözsesleniş = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    önsöz = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anasayfas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "anasayfas");
        }
    }
}
