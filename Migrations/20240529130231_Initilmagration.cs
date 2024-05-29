using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccentureChallenge.UI.Migrations
{
    /// <inheritdoc />
    public partial class Initilmagration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionCurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalHour = table.Column<int>(type: "int", nullable: false),
                    TransactionScenario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionIPAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IPState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IPPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IPCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsProxyIP = table.Column<bool>(type: "bit", nullable: false),
                    BrowserLanguage = table.Column<int>(type: "int", nullable: false),
                    PaymentInstrumentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentBillingPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentBillingState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentBillingCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CvvVerifyResult = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DigitalItemCount = table.Column<int>(type: "int", nullable: false),
                    PhysicalItemCount = table.Column<int>(type: "int", nullable: false),
                    TransactionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");
        }
    }
}
