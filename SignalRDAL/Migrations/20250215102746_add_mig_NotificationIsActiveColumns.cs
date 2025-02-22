using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalRDAL.Migrations
{
    public partial class add_mig_NotificationIsActiveColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Notifications",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Notifications");
        }
    }
}
