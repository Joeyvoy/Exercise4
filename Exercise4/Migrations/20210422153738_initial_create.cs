using Microsoft.EntityFrameworkCore.Migrations;

namespace Exercise4.Migrations
{
    public partial class initial_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerModel",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Address = table.Column<string>(nullable: false),
                    CheckIn = table.Column<string>(nullable: false),
                    CheckOut = table.Column<string>(nullable: false),
                    RoomNumber = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    Billing = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerModel", x => x.CustomerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerModel");
        }
    }
}
