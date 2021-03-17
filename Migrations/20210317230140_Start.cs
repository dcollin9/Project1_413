using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Group1_7_Project1_IS413.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Avail = table.Column<bool>(type: "INTEGER", nullable: false),
                    DayTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GroupName = table.Column<string>(type: "TEXT", nullable: true),
                    GroupSize = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNum = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tours");
        }
    }
}
