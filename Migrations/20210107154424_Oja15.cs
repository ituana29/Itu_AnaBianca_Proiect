using Microsoft.EntityFrameworkCore.Migrations;

namespace Itu_AnaBianca_Proiect.Migrations
{
    public partial class Oja15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oja",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Culoare = table.Column<string>(nullable: true),
                    Firma = table.Column<string>(nullable: true),
                    Pret = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oja", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oja");
        }
    }
}
