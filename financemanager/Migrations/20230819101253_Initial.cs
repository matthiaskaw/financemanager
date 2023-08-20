using Microsoft.EntityFrameworkCore.Migrations;

namespace financemanager.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VRTransaction",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ibanclient = table.Column<string>(name: "iban client", maxLength: 22, nullable: false),
                    bicclient = table.Column<string>(name: "bic client", maxLength: 11, nullable: false),
                    clientaccount = table.Column<string>(name: "client account", nullable: true),
                    bookindate = table.Column<string>(name: "bookin date", maxLength: 10, nullable: false),
                    valuedate = table.Column<string>(name: "value date", maxLength: 10, nullable: false),
                    namepayee = table.Column<string>(name: "name payee", nullable: false),
                    payeeIBAN = table.Column<string>(name: "payee IBAN", maxLength: 22, nullable: false),
                    payeeBIC = table.Column<string>(name: "payee BIC", maxLength: 11, nullable: false),
                    bookingtext = table.Column<string>(name: "booking text", nullable: false),
                    purposeofuse = table.Column<string>(name: "purpose of use", nullable: false),
                    amount = table.Column<string>(nullable: false),
                    saldoafterbooking = table.Column<string>(name: "saldo after booking", nullable: false),
                    note = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true),
                    taxrelevant = table.Column<string>(name: "tax relevant", nullable: true),
                    creditorid = table.Column<string>(name: "creditor id", nullable: false),
                    mandatereference = table.Column<string>(name: "mandate reference", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VRTransaction", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VRTransaction");
        }
    }
}
