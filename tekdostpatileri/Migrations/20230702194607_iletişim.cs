using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekdostpatileri.Migrations
{
    public partial class iletişim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "iletişims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İnstagram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tweater = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Youtube = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iletişims", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "iletişims");
        }
    }
}
