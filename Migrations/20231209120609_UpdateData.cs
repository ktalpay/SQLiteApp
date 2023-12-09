using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SQLiteApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CurrencyName", "CurrencyRate", "RateDate" },
                values: new object[,]
                {
                    { 1, "$", 29.0, new DateTime(2023, 12, 9, 15, 6, 8, 905, DateTimeKind.Local).AddTicks(4100) },
                    { 2, "€", 31.0, new DateTime(2023, 12, 9, 15, 6, 8, 905, DateTimeKind.Local).AddTicks(4210) },
                    { 3, "£", 36.0, new DateTime(2023, 12, 9, 15, 6, 8, 905, DateTimeKind.Local).AddTicks(4220) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
