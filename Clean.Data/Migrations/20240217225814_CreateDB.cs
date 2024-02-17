using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.Data.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    IdClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameClient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeClient = table.Column<int>(type: "int", nullable: false),
                    AdressClient = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    IdDoctors = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameDoctors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalaryDoctors = table.Column<int>(type: "int", nullable: false),
                    HoursDoctors = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.IdDoctors);
                });

            migrationBuilder.CreateTable(
                name: "Turns",
                columns: table => new
                {
                    NumTurn = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsAvailableTurn = table.Column<bool>(type: "bit", nullable: false),
                    DateTimeTurn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumRoom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turns", x => x.NumTurn);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Turns");
        }
    }
}
