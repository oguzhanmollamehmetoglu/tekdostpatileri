using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tekdostpatileri.Migrations
{
    public partial class hizmetler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hizmetlers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ihbarp1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ihbarp2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sağlıkp1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sağlıkp2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sağlıkp3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sağlıkimg1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sağlıkimg2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kısırlaştırmap1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kısırlaştırmap2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kısırlaştırmap3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kısırlaştırmap4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kısırlaştırmap5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kısırlaştırmap6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kısırlaştırmap7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kısırlaştırmaimg1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kısırlaştırmaimg2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    şiddetp1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    şiddetp2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    şiddetp3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    şiddetp4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eğitimp1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    donörimg1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    donörp1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sponsorimg1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sponsorp1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hizmetlers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hizmetlers");
        }
    }
}
