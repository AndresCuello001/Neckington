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
                table: "CreateContactDto",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CreateContactDto_UserEmail",
                table: "CreateContactDto",
                column: "UserEmail",
                unique: true,
                filter: "[UserEmail] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CreateContactDto_UserEmail",
                table: "CreateContactDto");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "CreateContactDto");
        }
    }
}
