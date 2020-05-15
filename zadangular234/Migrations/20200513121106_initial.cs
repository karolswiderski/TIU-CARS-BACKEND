using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace zadangular234.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Samochody",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Marka = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    KM = table.Column<string>(nullable: true),
                    Silnik = table.Column<string>(nullable: true),
                    Sciezka = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samochody", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Samochody");
        }
    }
}
