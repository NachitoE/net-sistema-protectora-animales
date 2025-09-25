using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserStatus = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Active"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AnimalState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressNumber = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Houses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "AnimalState", "BirthDate", "Description", "Name", "Species", "UserId" },
                values: new object[,]
                {
                    { "1", "Disponible", new DateTime(2018, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Como es el bichito", "Firulais", "Perro", null },
                    { "2", "Disponible", new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Como es el bichito", "Miau", "Gato", null },
                    { "3", "Disponible", new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Como es el bichito", "Bunny", "Conejo", null },
                    { "6", "Disponible", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Como es el bichito", "Coco", "Conejo", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Dni", "Name", "Password", "SurName", "UserName", "UserType" },
                values: new object[,]
                {
                    { "user-1", "12345678", "UTN", "123", "Rosario", "utn", "Admin" },
                    { "user-2", "87654321", "Camila", "123", "Stella", "cami", "Adoptante" },
                    { "user-3", "44180117", "Ignacio", "123", "Esteves", "nacho", "Voluntario" },
                    { "user-4", "11223344", "Nicolás", "123", "Salerno", "niko", "Transito" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "AnimalState", "BirthDate", "Description", "Name", "Species", "UserId" },
                values: new object[,]
                {
                    { "4", "Adoptado", new DateTime(2019, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Lola", "Gato", "user-4" },
                    { "5", "Adoptado", new DateTime(2017, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Como es el bichito", "Rex", "Perro", "user-2" },
                    { "7", "Adoptado", new DateTime(2016, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Como es el bichito", "Pepi", "Pajaro", "user-3" }
                });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AddressNumber", "Capacity", "UserId" },
                values: new object[] { "house-1", "Zeballos", 1341, 2, "user-4" });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_UserId",
                table: "Animals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_UserId",
                table: "Houses",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
