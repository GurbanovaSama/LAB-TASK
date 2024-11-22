using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaMVC.Migrations
{
    /// <inheritdoc />
    public partial class CreatedSliderItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_sliderItems",
                table: "sliderItems");

            migrationBuilder.RenameTable(
                name: "sliderItems",
                newName: "SliderItems");

            migrationBuilder.RenameColumn(
                name: "Offer",
                table: "SliderItems",
                newName: "DiscountPercent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SliderItems",
                table: "SliderItems",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SliderItems",
                table: "SliderItems");

            migrationBuilder.RenameTable(
                name: "SliderItems",
                newName: "sliderItems");

            migrationBuilder.RenameColumn(
                name: "DiscountPercent",
                table: "sliderItems",
                newName: "Offer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sliderItems",
                table: "sliderItems",
                column: "Id");
        }
    }
}
