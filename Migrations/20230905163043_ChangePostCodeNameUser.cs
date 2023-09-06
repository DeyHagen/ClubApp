using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassMembershipApplication.Migrations
{
    /// <inheritdoc />
    public partial class ChangePostCodeNameUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressPostalCode",
                table: "Users",
                newName: "PostCode");

            migrationBuilder.AlterColumn<string>(
                name: "AddressSecondLine",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostCode",
                table: "Users",
                newName: "AddressPostalCode");

            migrationBuilder.AlterColumn<int>(
                name: "AddressSecondLine",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
