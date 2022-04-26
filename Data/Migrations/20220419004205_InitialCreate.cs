using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customerOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    MiddleInitial = table.Column<char>(type: "TEXT", nullable: false),
                    Address1 = table.Column<string>(type: "TEXT", nullable: false),
                    Address2 = table.Column<string>(type: "TEXT", nullable: true),
                    ApartmentNumber = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    ZipCode = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    CreditCard = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pizzaOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CrustType = table.Column<int>(type: "INTEGER", nullable: false),
                    SauceType = table.Column<int>(type: "INTEGER", nullable: false),
                    CrustFlavor = table.Column<int>(type: "INTEGER", nullable: false),
                    HasExtraCheese = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasPepperoni = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasOlives = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasChicken = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasOnions = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasPineapple = table.Column<bool>(type: "INTEGER", nullable: true),
                    UserID = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerOrderId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pizzaOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pizzaOrders_customerOrders_CustomerOrderId",
                        column: x => x.CustomerOrderId,
                        principalTable: "customerOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pizzaOrders_CustomerOrderId",
                table: "pizzaOrders",
                column: "CustomerOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pizzaOrders");

            migrationBuilder.DropTable(
                name: "customerOrders");
        }
    }
}
