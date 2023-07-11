using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.Infrastructure.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuperHeroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pseudonym = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Firstname = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Lastname = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PictureUrl = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperHeroes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperHeroes");
        }
    }
}
