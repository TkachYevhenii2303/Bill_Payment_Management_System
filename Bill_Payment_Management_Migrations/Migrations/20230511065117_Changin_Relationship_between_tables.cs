using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bill_Payment_Management_Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Changin_Relationship_between_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_BankAccounts_BankAccountId",
                table: "PaymentMethods");

            migrationBuilder.RenameColumn(
                name: "BankAccountId",
                table: "PaymentMethods",
                newName: "BankAccountsId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_BankAccountId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_BankAccountsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_BankAccounts_BankAccountsId",
                table: "PaymentMethods",
                column: "BankAccountsId",
                principalTable: "BankAccounts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_BankAccounts_BankAccountsId",
                table: "PaymentMethods");

            migrationBuilder.RenameColumn(
                name: "BankAccountsId",
                table: "PaymentMethods",
                newName: "BankAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_BankAccountsId",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_BankAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_BankAccounts_BankAccountId",
                table: "PaymentMethods",
                column: "BankAccountId",
                principalTable: "BankAccounts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
