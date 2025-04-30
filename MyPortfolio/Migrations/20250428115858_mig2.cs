using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Portfolios",
                newName: "ThumbnailImageUrl");

            migrationBuilder.AddColumn<string>(
                name: "GalleryImageUrl",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GalleryImageUrl",
                table: "Portfolios");

            migrationBuilder.RenameColumn(
                name: "ThumbnailImageUrl",
                table: "Portfolios",
                newName: "ImageUrl");
        }
    }
}
