using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulky.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class ModifyOrderHEaderTTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransactionNumber",
                table: "OrderHeaders",
                newName: "TrackingNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrackingNumber",
                table: "OrderHeaders",
                newName: "TransactionNumber");
        }
    }
}
