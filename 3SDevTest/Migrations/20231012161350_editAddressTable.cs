using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3SDevTest.Migrations
{
    /// <inheritdoc />
    public partial class editAddressTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Governates_GovernateId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_GovernateId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "GovernateId",
                table: "Addresses");

            migrationBuilder.AddColumn<string>(
                name: "Governate",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Governate",
                value: "Governate 1");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Governate",
                value: "Governate 1");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Governate",
                value: "Governate 2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Governate",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "GovernateId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "GovernateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "GovernateId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "GovernateId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_GovernateId",
                table: "Addresses",
                column: "GovernateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Governates_GovernateId",
                table: "Addresses",
                column: "GovernateId",
                principalTable: "Governates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
