using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseBack.Migrations
{
    public partial class AddedProjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    ShortTitle = table.Column<string>(maxLength: 200, nullable: false),
                    MainTitle = table.Column<string>(maxLength: 500, nullable: false),
                    TotalArea = table.Column<int>(nullable: false),
                    Floors = table.Column<int>(nullable: false),
                    LivingRooms = table.Column<int>(nullable: false),
                    ConstructionPeriod = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    MainImageUrl = table.Column<string>(nullable: true),
                    PlanImgUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
