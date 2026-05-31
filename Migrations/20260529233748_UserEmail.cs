using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Neckington.Migrations
{
    /// <inheritdoc />
    public partial class UserEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Contact",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UserEmail",
                table: "Contact",
                column: "UserEmail",
                unique: true,
                filter: "[UserEmail] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contact_UserEmail",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Contact");
        }
    }
}
