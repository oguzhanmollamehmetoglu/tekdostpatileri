using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekdostpatileri.Migrations
{
    public partial class yuvamız : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "yuvamızs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YuvaResim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yuvaİsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YuvaHikaye = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YuvaCinsi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YuvaYaşı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YuvaRengi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YuvaCinsiyeti = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yuvamızs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "yuvamızs");
        }
    }
}
