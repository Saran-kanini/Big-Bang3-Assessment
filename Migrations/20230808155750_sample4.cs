using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Big_Bang3_Assessment.Migrations
{
    /// <inheritdoc />
    public partial class sample4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "booking_amount_with_gst",
                table: "Booking",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "booking_amount_with_gst",
                table: "Booking");
        }
    }
}
