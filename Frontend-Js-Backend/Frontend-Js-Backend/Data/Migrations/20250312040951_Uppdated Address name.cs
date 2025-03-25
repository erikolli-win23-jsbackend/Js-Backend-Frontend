using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frontend_Js_Backend.Migrations
{
    /// <inheritdoc />
    public partial class UppdatedAddressname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressLine_2",
                table: "Addresses",
                newName: "AddressLine2");

            migrationBuilder.RenameColumn(
                name: "AddressLine_1",
                table: "Addresses",
                newName: "AddressLine1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressLine2",
                table: "Addresses",
                newName: "AddressLine_2");

            migrationBuilder.RenameColumn(
                name: "AddressLine1",
                table: "Addresses",
                newName: "AddressLine_1");
        }
    }
}
