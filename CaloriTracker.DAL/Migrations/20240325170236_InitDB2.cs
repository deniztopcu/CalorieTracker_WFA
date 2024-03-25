using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaloriTracker.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 20, 2, 35, 672, DateTimeKind.Local).AddTicks(5178));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 3, 25, 16, 13, 14, 39, DateTimeKind.Local).AddTicks(4919));
        }
    }
}
