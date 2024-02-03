using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agentesfiguras.Migrations
{
    /// <inheritdoc />
    public partial class Migracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionalidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombrefuncionalidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombreagente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numn = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionalidades", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionalidades");
        }
    }
}
