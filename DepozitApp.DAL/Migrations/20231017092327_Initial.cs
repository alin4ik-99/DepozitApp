using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepozitApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MounthlyDepozitReports",
                columns: table => new
                {
                    MounthId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberMounth = table.Column<int>(type: "int", nullable: false),
                    MounthDepozit = table.Column<double>(type: "float", nullable: false),
                    MounthlyIncome = table.Column<double>(type: "float", nullable: false),
                    MounthlyPlus = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MounthlyDepozitReports", x => x.MounthId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MounthlyDepozitReports");
        }
    }
}
