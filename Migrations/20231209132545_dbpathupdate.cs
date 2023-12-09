using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SQLiteApp.Migrations
{
    /// <inheritdoc />
    public partial class dbpathupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "RateDate",
                value: new DateTime(2023, 12, 9, 16, 25, 44, 993, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "RateDate",
                value: new DateTime(2023, 12, 9, 16, 25, 44, 993, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "RateDate",
                value: new DateTime(2023, 12, 9, 16, 25, 44, 993, DateTimeKind.Local).AddTicks(3840));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "RateDate",
                value: new DateTime(2023, 12, 9, 15, 6, 8, 905, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "RateDate",
                value: new DateTime(2023, 12, 9, 15, 6, 8, 905, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "RateDate",
                value: new DateTime(2023, 12, 9, 15, 6, 8, 905, DateTimeKind.Local).AddTicks(4220));
        }
    }
}
