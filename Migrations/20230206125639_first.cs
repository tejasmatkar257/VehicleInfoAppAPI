using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle_Info_APP.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatePassing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionalCode = table.Column<int>(type: "int", nullable: false),
                    Alphabets = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleNumber = table.Column<int>(type: "int", nullable: false),
                    UserState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
