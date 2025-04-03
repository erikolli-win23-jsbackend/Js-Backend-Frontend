using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frontend_Js_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Notificationnewsletter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribedToNewsletter",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NewsletterEmail",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSubscribedToNewsletter",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NewsletterEmail",
                table: "AspNetUsers");
        }
    }
}
