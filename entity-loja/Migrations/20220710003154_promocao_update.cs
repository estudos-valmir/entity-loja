using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entity_loja.Migrations
{
    public partial class promocao_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataIniciao",
                table: "Promocoes",
                newName: "DataIniciacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataIniciacao",
                table: "Promocoes",
                newName: "DataIniciao");
        }
    }
}
