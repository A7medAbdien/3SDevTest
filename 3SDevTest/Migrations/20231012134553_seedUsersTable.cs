using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _3SDevTest.Migrations
{
    /// <inheritdoc />
    public partial class seedUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "MiddleName", "MobileNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ex@gmail.com", "FirstName1", "LastName1", "MiddleName1", "+021006158123" },
                    { 2, new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "ex@gmail.com", "FirstName2", "LastName2", "MiddleName2", "+022006258223" },
                    { 3, new DateTime(2020, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "ex@gmail.com", "FirstName3", "LastName3", "MiddleName3", "+023006358323" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
