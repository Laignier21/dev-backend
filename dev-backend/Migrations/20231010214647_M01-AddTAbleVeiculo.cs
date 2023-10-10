using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dev_backend.Migrations
{
    public partial class M01AddTAbleVeiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placa = table.Column<int>(type: "int", nullable: false),
                    AnoFabricação = table.Column<int>(type: "int", nullable: false),
                    AnoModelo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculo");
        }
    }
}
