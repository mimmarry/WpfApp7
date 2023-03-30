using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfApp7.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    MyProperty = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.MyProperty);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    IdBill = table.Column<Guid>(type: "uuid", nullable: false),
                    AccountMyProperty = table.Column<Guid>(type: "uuid", nullable: true),
                    Balance = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.IdBill);
                    table.ForeignKey(
                        name: "FK_Bills_Accounts_AccountMyProperty",
                        column: x => x.AccountMyProperty,
                        principalTable: "Accounts",
                        principalColumn: "MyProperty");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_AccountMyProperty",
                table: "Bills",
                column: "AccountMyProperty");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
