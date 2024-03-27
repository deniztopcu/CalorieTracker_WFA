using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaloriTracker.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDBtotalCalorie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalCalorie",
                table: "UserMealDetail",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1902), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1919), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1921), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1922), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1923), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1924), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1925), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1926), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1927), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1928), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1929), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1930), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1931), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1934), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1935), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2102), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2175), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2180), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2184), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2188), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2191), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2195), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2198), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2201), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2204), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2208), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2211), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2214), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2218), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2220), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2225), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2228), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2231), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2234), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2237), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2240), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2245), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2248), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2251), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2255), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2257), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2260), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2265), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2268), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2271), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2274), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2277), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2280), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2283), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2286), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2290), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2293), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2301), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2305), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2309), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2312), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2315), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2318), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2324), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2327), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2330), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2333), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2336), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2339), 0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2342), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2346), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2349), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2352), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2355), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2358), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2361), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2364), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2367), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2370), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2373), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2376), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2380), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2383), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2386), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2389), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2392), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2395), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2398), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2402), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2405), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2408), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2411), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2415), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2419), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2422), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2425), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2428), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2431), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2434), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2437), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2440), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2443), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2446), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2449), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2454), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2457), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2460), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2463), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2466), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2469), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2472), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2475), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2480), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2484), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2487), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2490), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2493), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2496), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2499), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2502), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2505), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2508), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2511), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2514), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2517), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2520), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2529), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2534), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2538), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2542), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2545), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2549), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2553), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2558), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2562), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2566), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 117,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2569), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 118,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2573), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2577), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2580), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2584), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2587), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2590), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2593), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2596), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2599), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2603), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2606), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2609), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2612), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2616), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2619), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2622), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2624), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2627), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2630), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2633), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 138,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2637), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 139,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2640), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2643), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 141,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2646), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 142,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2650), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 143,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2653), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 144,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2656), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2659), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2662), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2665), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2668), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 149,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2671), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 150,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2674), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 151,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2677), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2680), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 153,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2684), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 154,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2687), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2690), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2693), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2696), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2699), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2702), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2705), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2708), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2711), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2715), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2718), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 165,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2721), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2724), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2727), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 168,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2730), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2733), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2736), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 171,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2739), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2742), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2745), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2749), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2758), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2762), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 177,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2765), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2769), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2772), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2775), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 181,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2778), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 182,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2781), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 183,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2784), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 184,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2787), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2790), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2793), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2796), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 188,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2803), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2806), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2809), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 191,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2812), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2815), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2818), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 194,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2821), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2824), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2827), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2831), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 198,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2833), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 199,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2837), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2840), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2843), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2846), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2849), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2852), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2855), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2858), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2861), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2864), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2867), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2870), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2874), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2877), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2880), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2883), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 215,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2886), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2889), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2892), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2895), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2898), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2901), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2904), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2908), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2911), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2914), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2917), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2920), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2923), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2926), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2929), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2932), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2935), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2938), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2942), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2945), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2948), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2952), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2955), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2958), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2961), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2964), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 241,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2967), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 242,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2970), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 243,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2978), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2981), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 245,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2985), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 246,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2988), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2991), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2994), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2997), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 250,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(2999), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3002), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3005), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 253,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3008), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 254,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3012), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 255,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3014), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 256,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3018), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3021), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3024), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3030), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3033), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3036), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 262,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3038), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 263,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3041), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 264,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3044), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3048), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 266,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3051), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 267,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3054), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3058), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 269,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3062), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 270,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3065), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3067), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3071), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3074), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3077), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3080), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3083), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3086), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3089), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3093), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3096), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3099), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 282,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3102), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3106), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 284,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3109), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 285,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3112), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3115), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3118), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3121), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3124), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3128), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3132), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3136), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 293,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3139), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 294,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3143), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3147), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3150), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3154), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3157), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3161), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3164), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3168), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3173), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3176), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3179), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3182), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3185), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3188), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3191), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3194), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3197), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3200), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3208), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3211), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3214), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3217), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3220), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3223), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3226), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3229), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3232), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3235), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3238), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3241), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3244), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3248), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3251), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3254), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3257), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3260), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3263), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3268), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3271), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 333,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3274), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3277), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3280), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3284), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3287), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3290), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3293), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3296), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3299), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3302), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3305), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3308), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3311), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 346,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3314), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 347,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3318), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3321), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3324), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3327), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3330), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3333), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3336), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3339), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3342), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3345), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 357,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3348), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3351), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3356), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3359), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3362), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3365), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3368), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 364,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3371), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 365,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3374), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3378), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3381), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3383), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3386), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3391), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3394), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 372,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3397), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 373,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3400), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3403), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3405), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3408), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3412), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3415), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 379,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3420), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 380,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3427), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3430), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 382,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3434), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 383,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3437), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3441), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 385,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3444), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 386,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3447), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3450), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3452), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3455), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3458), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3462), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 392,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3464), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3468), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3471), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3474), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3477), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3481), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3484), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3487), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3490), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3493), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3497), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3500), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3504), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3507), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3510), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3513), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3516), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3519), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3522), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3525), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3528), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3531), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3534), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3537), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3541), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3544), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3547), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3550), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3553), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3556), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3559), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3562), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3565), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3568), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3571), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3576), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3579), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3582), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3585), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3588), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3591), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 433,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3594), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3597), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3600), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3603), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3607), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3610), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3613), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3617), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3620), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3623), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3626), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3629), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 445,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3632), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 446,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3635), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 447,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3638), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3646), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3649), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3653), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3656), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3660), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3662), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3665), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3668), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3671), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3674), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3677), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3680), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3683), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3687), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3690), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3693), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3696), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3699), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3702), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3705), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3708), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3710), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3713), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3717), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 472,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3720), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 473,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3725), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3728), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3732), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3736), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3739), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3743), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3747), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3750), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3754), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3758), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3762), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 484,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3766), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 485,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3769), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 486,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3773), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3776), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3779), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3782), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3785), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3788), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3791), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3794), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3797), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3800), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3808), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3811), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3814), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3817), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3820), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 501,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3823), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 502,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3826), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 503,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3829), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 504,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3832), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 505,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3835), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 506,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3838), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 507,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3843), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 508,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3846), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 509,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3849), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 510,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3852), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 511,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3855), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 512,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3858), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 513,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3861), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 514,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3864), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 515,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3867), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 516,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3870), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 517,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3877), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 518,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3880), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 519,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3886), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 520,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3890), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 521,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3893), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 522,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3896), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 523,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3899), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 524,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3902), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 525,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3905), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 526,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3908), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 527,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3911), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 528,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3914), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 529,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3917), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 530,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3921), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 531,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3924), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 532,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3927), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 533,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3930), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 534,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3933), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 535,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3937), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 536,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3940), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 537,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3943), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 538,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3946), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 539,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3949), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 540,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3952), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 541,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3956), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 542,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3959), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 543,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3962), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 544,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3965), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 545,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3969), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 546,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3972), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 547,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3975), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 548,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3978), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 549,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3981), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 550,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3984), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 551,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3987), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 552,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3990), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 553,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3994), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 554,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(3997), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 555,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4000), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 556,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4003), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 557,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4006), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 558,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4009), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 559,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4012), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 560,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4015), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 561,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4018), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 562,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4021), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 563,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4024), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 564,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4028), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 565,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4032), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 566,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4034), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 567,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4037), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 568,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4040), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 569,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4045), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 570,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4049), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 571,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4052), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 572,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4055), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 573,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4058), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 574,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4060), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 575,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4063), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 576,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4067), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 577,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4070), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 578,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4073), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 579,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4076), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 580,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4080), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 581,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4083), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 582,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4085), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 583,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4088), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 584,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4092), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 585,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4099), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 586,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4102), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 587,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4106), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 588,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4109), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 589,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4113), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 590,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4116), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 591,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4121), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 592,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4124), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 593,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4127), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 594,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4130), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 595,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4132), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 596,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4135), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 597,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4138), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 598,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4142), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 599,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4145), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 600,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4148), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 601,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4151), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 602,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4154), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 603,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4157), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 604,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4160), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 605,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4163), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 606,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4166), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 607,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4169), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 608,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4172), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 609,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4175), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 610,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4179), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 611,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4182), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 612,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4185), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 613,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4188), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 614,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4191), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 615,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4195), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 616,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4198), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 617,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4200), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 618,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4204), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 619,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4207), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 620,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4210), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 621,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4214), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 622,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4217), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 623,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4220), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 624,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4223), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 625,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4226), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 626,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4229), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 627,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4232), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 628,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4235), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 629,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4238), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 630,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4241), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 631,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4244), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 632,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4247), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 633,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4251), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 634,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4254), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 635,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4257), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 636,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4260), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 637,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4263), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 638,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4266), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 639,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4269), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 640,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4272), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 641,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4275), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 642,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4278), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 643,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4281), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 644,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4285), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 645,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4288), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 646,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4291), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 647,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4294), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 648,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4297), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 649,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4300), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 650,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4303), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 651,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4306), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 652,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4309), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 653,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4317), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 654,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4320), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 655,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4324), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 656,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4328), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 657,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4332), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 658,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4336), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 659,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4340), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 660,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4343), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 661,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4347), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 662,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4351), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 663,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4354), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 664,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4358), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 665,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4362), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 666,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4365), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 667,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4370), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 668,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4373), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 669,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4376), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 670,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4379), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 671,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4382), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 672,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4385), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 673,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4388), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 674,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4391), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 675,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4394), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 676,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4397), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 677,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4400), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 678,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4404), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 679,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4407), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 680,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4410), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 681,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4413), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 682,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4416), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 683,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4419), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 684,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4422), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 685,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4425), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 686,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4428), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 687,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4431), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 688,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4434), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 689,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4439), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 690,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4442), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 691,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4445), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 692,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4448), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 693,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4451), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 694,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4455), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 695,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4458), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 696,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4461), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 697,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4464), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 698,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4467), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 699,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4470), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 700,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4473), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 701,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4476), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 702,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4480), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 703,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4483), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 704,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4486), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 705,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4489), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 706,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4492), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 707,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4495), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 708,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4498), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 709,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4501), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 710,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4504), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 711,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4507), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 712,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4511), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 713,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4515), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 714,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4517), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 715,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4521), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 716,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4524), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 717,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4527), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 718,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4530), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 719,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4532), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 720,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4535), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 721,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4538), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 722,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4547), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 723,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4550), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 724,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4554), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 725,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4558), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 726,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4561), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 727,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4564), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 728,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4567), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 729,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4570), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 730,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4573), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 731,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4576), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 732,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4579), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 733,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4582), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 734,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4585), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 735,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4590), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 736,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4593), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 737,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4596), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 738,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4599), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 739,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4602), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 740,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4605), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 741,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4608), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 742,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4611), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 743,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4614), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 744,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4617), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 745,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4620), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 746,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4623), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 747,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4627), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 748,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4630), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 749,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4633), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 750,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4636), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 751,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4639), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 752,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4643), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 753,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4646), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 754,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4649), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 755,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4652), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 756,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4655), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 757,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4658), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 758,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4662), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 759,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4665), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 760,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4668), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 761,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4671), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 762,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4674), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 763,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4677), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 764,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4680), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 765,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4683), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 766,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4686), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 767,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4689), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 768,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4692), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 769,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4695), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 770,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4699), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 771,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4702), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 772,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4705), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 773,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4708), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 774,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4711), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 775,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4714), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 776,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4717), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 777,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4720), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 778,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4723), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 779,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4726), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 780,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4729), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 781,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4754), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 782,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4759), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 783,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4762), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 784,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4765), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 785,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4769), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 786,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4771), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 787,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4774), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 788,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4777), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 789,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4780), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 790,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4790), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 791,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4793), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 792,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4797), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 793,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4800), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 794,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4803), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 795,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4807), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 796,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4810), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 797,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4813), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 798,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4816), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 799,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4819), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 800,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4822), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 801,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4826), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 802,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4829), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 803,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4832), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 804,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4836), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 805,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4839), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 806,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4842), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 807,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(4845), 7 });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(5294), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(5296), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(5297), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(5298), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 18, 55, 35, 999, DateTimeKind.Local).AddTicks(5299) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalCalorie",
                table: "UserMealDetail");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(46), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(59), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(61), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(62), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(63), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(63), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(64), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(65), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(66), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(67), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(67), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(68), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(69), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(69), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(70), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(70), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(71), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(72), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(73), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(73), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(74), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(74), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(75), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(76), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(76), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(77), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(78), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(78), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(79), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(79), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(253), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(252), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(324), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(324), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(329), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(329), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(333), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(332), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(336), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(336), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(340), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(339), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(344), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(343), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(348), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(347), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(351), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(351), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(355), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(354), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(358), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(358), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(361), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(361), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(366), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(365), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(369), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(369), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(372), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(372), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(376), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(375), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(379), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(379), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(382), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(382), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(386), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(385), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(389), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(389), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(392), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(392), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(395), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(395), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(399), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(398), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(403), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(403), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(407), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(406), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(410), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(410), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(419), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(419), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(423), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(423), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(427), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(426), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(430), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(430), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(434), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(433), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(437), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(437), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(440), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(440), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(444), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(443), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(447), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(447), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(451), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(451), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(455), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(454), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(458), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(458), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(461), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(461), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(465), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(464), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(468), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(468), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(471), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(471), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(474), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(474), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(478), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(478), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(481), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(481), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(484), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(484), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(489), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(488), 2 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(492), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(492), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(495), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(495), 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(498), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(498), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(504), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(504), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(507), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(507), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(511), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(510), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(514), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(514), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(517), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(517), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(521), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(520), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(524), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(524), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(527), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(527), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(531), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(531), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(534), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(534), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(537), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(541), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(541), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(544), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(544), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(547), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(547), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(551), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(550), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(554), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(553), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(557), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(560), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(560), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(563), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(563), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(568), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(567), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(571), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(570), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(574), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(574), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(577), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(577), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(583), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(582), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(586), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(586), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(589), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(589), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(592), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(592), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(596), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(595), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(599), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(599), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(602), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(602), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(605), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(605), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(610), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(610), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(613), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(613), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(617), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(616), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(620), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(620), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(623), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(623), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(626), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(626), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(630), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(629), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(633), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(632), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(636), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(636), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(639), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(639), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(643), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(642), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(647), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(647), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(650), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(650), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(707), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(707), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(712), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(712), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(717), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(717), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(723), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(723), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(728), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(728), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(733), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(732), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(739), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(739), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(744), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(744), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(750), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(749), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(756), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(756), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(762), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(761), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(767), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(767), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(772), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(777), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(777), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(782), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(782), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(787), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(787), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(792), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(792), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(797), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(797), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(802), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(802), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(807), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(807), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(813), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(812), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(819), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 117,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(825), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(824), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 118,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(830), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(830), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(836), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(835), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(841), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(840), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(845), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(845), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(850), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(850), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(854), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(854), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(859), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(859), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(864), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(863), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(868), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(868), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(875), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(874), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(880), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(880), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(885), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(884), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(889), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(889), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(894), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(894), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(899), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(899), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(903), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(903), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(908), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(908), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(913), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(913), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(918), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(918), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(924), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(924), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 138,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(930), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 139,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(937), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(936), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(942), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(942), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 141,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(948), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(947), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 142,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(954), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(953), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 143,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(959), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(959), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 144,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(964), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(964), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(970), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(970), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(976), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(975), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(981), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(981), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(987), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(986), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 149,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(993), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(992), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 150,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1000), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(999), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 151,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1006), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1005), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1012), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1011), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 153,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1017), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1017), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 154,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1023), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1022), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1028), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1027), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1032), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1032), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1037), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1037), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1042), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1041), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1047), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1046), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1054), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1053), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1060), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1060), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1065), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1064), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1070), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1069), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1083), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1083), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 165,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1089), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1088), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1094), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1094), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1099), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1098), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 168,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1104), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1104), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1109), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1109), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1115), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1114), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 171,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1120), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1120), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1124), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1124), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1131), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1130), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1136), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1136), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1142), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1142), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1148), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1147), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 177,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1154), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1153), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1159), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1165), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1164), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1170), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1170), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 181,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1175), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1175), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 182,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1181), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1180), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 183,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1186), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1186), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 184,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1192), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1192), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1198), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1198), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1204), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1203), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1210), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1209), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 188,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1216), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1215), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1221), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1220), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1227), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1226), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 191,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1232), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1232), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1237), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1237), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1243), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1243), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 194,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1248), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1248), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1254), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1253), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1261), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1260), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1266), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1266), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 198,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1272), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1271), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 199,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1278), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1278), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1285), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1285), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1291), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1290), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1296), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1296), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1301), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1301), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1307), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1307), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1312), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1312), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1318), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1318), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1325), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1324), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1331), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1330), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1337), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1336), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1342), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1342), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1349), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1348), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1354), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1353), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1362), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1362), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1367), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1367), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 215,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1373), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1373), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1379), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1378), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1384), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1384), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1391), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1390), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1396), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1396), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1402), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1402), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1408), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1407), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1413), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1413), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1420), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1419), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1425), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1424), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1431), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1430), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1436), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1436), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1444), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1444), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1450), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1449), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1455), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1455), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1462), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1462), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1468), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1468), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1479), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1479), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1485), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1485), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1491), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1491), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1497), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1496), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1503), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1502), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1508), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1507), 9 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1513), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1513), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1519), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1519), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1524), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1524), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 241,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1531), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1530), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 242,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1536), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1536), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 243,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1542), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1542), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1548), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1547), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 245,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1553), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1553), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 246,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1559), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1559), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1565), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1564), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1570), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1570), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1576), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1576), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 250,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1582), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1581), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1587), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1587), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1592), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1592), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 253,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1600), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1600), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 254,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1605), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1605), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 255,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1610), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1610), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 256,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1615), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1615), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1620), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1620), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1625), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1624), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1629), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1629), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1635), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1635), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1640), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1640), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 262,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1646), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1646), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 263,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1652), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1651), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 264,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1659), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1659), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1665), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1664), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 266,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1670), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1670), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 267,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1676), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1676), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1682), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1681), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 269,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1687), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1686), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 270,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1692), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1691), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1697), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1697), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1701), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1701), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1706), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1706), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1711), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1711), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1717), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1717), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1724), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1724), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1730), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1730), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1735), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1735), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1741), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1740), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1746), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1746), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1753), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1753), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 282,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1759), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1759), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1764), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1764), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 284,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1770), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1770), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 285,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1776), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1775), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1782), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1781), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1788), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1787), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1793), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1793), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1799), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1798), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1805), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1804), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1810), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1810), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1816), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1816), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 293,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1821), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1821), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 294,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1827), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1827), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1833), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1833), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1839), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1838), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1844), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1844), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1851), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1851), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1857), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1856), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1868), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1868), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1874), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1874), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1880), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1880), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1886), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1885), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1892), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1891), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1897), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1896), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1903), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1902), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1908), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1908), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1915), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1915), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1921), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1921), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1928), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1927), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1933), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1933), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1939), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1939), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1945), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1944), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1950), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1950), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1955), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1955), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1962), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1961), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1968), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1967), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1973), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1973), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1979), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1979), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1985), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1985), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1996), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1996), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2002), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2002), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2008), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2008), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2014), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2014), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2019), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2019), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2024), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2024), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2029), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2029), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2034), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2033), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2038), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2038), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2044), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2043), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2049), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2048), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2054), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2054), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 333,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2060), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2060), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2066), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2066), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2071), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2071), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2076), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2075), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2081), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2080), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2086), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2085), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2091), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2091), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2096), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2096), 10 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2101), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2101), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2106), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2106), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2111), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2111), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2118), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2117), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2123), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2123), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 346,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2128), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2128), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 347,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2133), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2133), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2139), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2138), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2144), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2144), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2149), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2149), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2154), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2154), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2159), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2159), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2164), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2164), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2169), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2169), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2176), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2175), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2180), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2180), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 357,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2187), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2186), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2192), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2191), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2195), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2195), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2199), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2198), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2202), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2202), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2205), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2205), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2209), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2208), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 364,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2212), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2212), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 365,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2215), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2215), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2218), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2218), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2224), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2223), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2227), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2227), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2236), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2235), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2239), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2239), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2242), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2242), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 372,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2246), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2245), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 373,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2249), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2248), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2252), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2252), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2255), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2255), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2258), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2258), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2262), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2261), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2266), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2266), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 379,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2269), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2269), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 380,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2272), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2272), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2276), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2275), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 382,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2279), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2279), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 383,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2282), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2282), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2285), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2285), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 385,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2289), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2288), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 386,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2292), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2291), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2295), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2295), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2298), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2298), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2302), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2301), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2306), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2306), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2309), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2309), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 392,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2312), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2312), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2316), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2315), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2319), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2319), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2322), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2322), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2326), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2325), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2329), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2329), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2403), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2402), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2411), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2410), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2414), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2414), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2419), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2419), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2422), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2422), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2425), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2425), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2429), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2428), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2432), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2432), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2435), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2435), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2438), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2438), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2441), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2441), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2445), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2444), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2448), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2448), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2451), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2451), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2456), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2456), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2459), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2459), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2463), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2462), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2466), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2466), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2469), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2469), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2473), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2472), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2476), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2476), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2479), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2479), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2482), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2482), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2485), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2485), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2489), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2488), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2492), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2492), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2496), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2496), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2500), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2499), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2503), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2503), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2506), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2506), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2510), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2510), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2513), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2513), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2516), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2516), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2520), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2520), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2523), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2523), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 433,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2526), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2526), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2529), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2529), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2540), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2539), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2543), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2543), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2551), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2551), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2555), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2554), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2558), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2558), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2561), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2561), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2565), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2564), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2568), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2568), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2571), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2571), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2574), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2574), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 445,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2578), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2577), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 446,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2581), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2581), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 447,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2585), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2585), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2589), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2588), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2592), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2592), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2595), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2595), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2598), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2598), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2602), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2601), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2605), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2604), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2608), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2608), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2611), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2611), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2616), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2616), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2620), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2619), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2623), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2623), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2626), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2626), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2630), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2629), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2633), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2633), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2636), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2636), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2639), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2639), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2643), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2642), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2646), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2645), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2649), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2649), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2722), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2721), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2725), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2724), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2729), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2729), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2733), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2733), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2737), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2737), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 472,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2786), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2786), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 473,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2792), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2792), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2796), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2796), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2800), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2799), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2803), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2803), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2807), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2807), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2811), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2811), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2815), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2814), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2818), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2818), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2823), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2822), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2826), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2826), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2830), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2829), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 484,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2833), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2833), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 485,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2836), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2836), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 486,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2839), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2839), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2843), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2842), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2846), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2845), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2849), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2849), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2852), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2852), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2856), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2855), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2860), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2860), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2863), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2863), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2867), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2866), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2870), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2870), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2873), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2873), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2876), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2876), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2880), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2879), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2883), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2883), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2886), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2886), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 501,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2889), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2889), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 502,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2892), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2892), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 503,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2896), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2895), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 504,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2900), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2900), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 505,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2909), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2908), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 506,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2912), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2911), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 507,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2915), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2915), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 508,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2918), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2918), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 509,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2922), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2921), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 510,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2925), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2924), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 511,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2928), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2928), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 512,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2932), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2931), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 513,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2935), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2935), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 514,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2938), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2938), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 515,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2943), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2942), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 516,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2946), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2946), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 517,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2949), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2949), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 518,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2953), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2952), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 519,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2956), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2956), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 520,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2959), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2959), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 521,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2962), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2962), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 522,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2965), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2965), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 523,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2969), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2968), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 524,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2972), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2972), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 525,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2975), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2975), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 526,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2979), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2979), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 527,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2984), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2983), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 528,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2987), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2987), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 529,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2990), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2990), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 530,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2993), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2993), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 531,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2997), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2996), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 532,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3000), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3000), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 533,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3003), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3003), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 534,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3007), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3007), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 535,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3010), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3010), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 536,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3013), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3013), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 537,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3017), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3016), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 538,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3022), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3021), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 539,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3025), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3025), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 540,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3029), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3028), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 541,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3032), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3032), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 542,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3035), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3035), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 543,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3039), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3038), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 544,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3042), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3042), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 545,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3045), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3045), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 546,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3048), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3048), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 547,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3052), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3051), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 548,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3055), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3054), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 549,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3059), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3059), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 550,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3062), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3062), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 551,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3065), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3065), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 552,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3069), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3068), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 553,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3072), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3072), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 554,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3075), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3075), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 555,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3078), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3078), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 556,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3083), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3083), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 557,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3086), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3086), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 558,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3090), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3089), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 559,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3093), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3093), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 560,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3096), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 561,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3101), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3100), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 562,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3104), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3104), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 563,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3108), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3107), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 564,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3111), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3110), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 565,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3114), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3114), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 566,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3117), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3117), 3 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 567,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3120), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3120), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 568,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3124), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3124), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 569,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3127), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3127), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 570,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3130), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3130), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 571,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3134), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3133), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 572,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3138), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3138), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 573,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3141), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3141), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 574,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3150), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3150), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 575,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3154), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3153), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 576,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3157), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3156), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 577,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3162), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3162), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 578,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3166), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3165), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 579,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3169), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3169), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 580,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3172), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3172), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 581,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3175), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3175), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 582,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3179), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3178), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 583,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3182), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3181), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 584,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3186), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3186), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 585,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3189), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3189), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 586,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3193), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3192), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 587,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3196), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3196), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 588,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3199), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3199), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 589,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3203), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3202), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 590,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3206), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3206), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 591,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3209), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3209), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 592,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3213), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3212), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 593,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3216), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3216), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 594,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3219), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3219), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 595,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3223), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3223), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 596,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3227), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3227), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 597,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3230), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3230), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 598,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3234), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3233), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 599,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3238), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3238), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 600,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3242), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3241), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 601,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3245), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3245), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 602,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3248), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3248), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 603,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3251), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3251), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 604,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3255), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3254), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 605,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3258), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3258), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 606,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3262), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3262), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 607,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3265), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3265), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 608,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3269), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3268), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 609,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3272), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3272), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 610,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3276), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3275), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 611,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3279), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3278), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 612,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3282), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3282), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 613,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3285), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3285), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 614,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3288), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3288), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 615,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3291), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3291), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 616,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3295), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3295), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 617,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3298), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3298), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 618,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3303), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3302), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 619,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3306), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3306), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 620,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3309), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3309), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 621,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3312), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3312), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 622,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3317), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3316), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 623,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3320), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3320), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 624,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3324), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3323), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 625,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3327), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3326), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 626,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3330), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3330), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 627,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3333), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3333), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 628,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3337), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3336), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 629,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3341), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3341), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 630,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3344), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3344), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 631,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3347), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3347), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 632,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3350), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3350), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 633,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3354), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3353), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 634,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3357), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3356), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 635,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3360), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3360), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 636,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3363), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3363), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 637,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3366), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3366), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 638,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3370), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3369), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 639,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3373), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3372), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 640,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3376), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3376), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 641,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3381), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3380), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 642,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3390), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3389), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 643,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3393), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3393), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 644,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3396), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3396), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 645,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3399), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3399), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 646,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3403), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3402), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 647,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3406), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3406), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 648,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3409), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3409), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 649,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3412), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3412), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 650,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3415), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3415), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 651,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3419), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3418), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 652,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3423), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3423), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 653,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3427), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3427), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 654,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3431), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3430), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 655,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3434), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3434), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 656,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3438), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3438), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 657,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3442), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3442), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 658,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3446), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3445), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 659,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3449), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3449), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 660,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3453), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3453), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 661,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3457), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3457), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 662,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3461), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3460), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 663,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3465), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 664,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3469), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3468), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 665,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3472), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3472), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 666,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3476), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3475), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 667,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3479), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3479), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 668,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3482), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3482), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 669,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3485), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3485), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 670,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3488), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3488), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 671,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3492), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3491), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 672,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3495), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3495), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 673,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3498), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3498), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 674,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3502), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3501), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 675,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3506), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3506), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 676,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3509), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3509), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 677,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3512), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3512), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 678,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3516), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3515), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 679,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3519), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3519), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 680,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3522), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3522), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 681,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3525), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3525), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 682,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3529), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3528), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 683,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3532), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3532), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 684,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3535), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3535), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 685,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3538), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3538), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 686,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3543), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3542), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 687,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3546), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3546), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 688,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3549), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3549), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 689,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3553), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3553), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 690,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3556), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3556), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 691,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3560), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3559), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 692,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3563), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3563), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 693,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3566), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3566), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 694,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3569), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3569), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 695,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3572), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3572), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 696,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3576), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3575), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 697,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3579), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3579), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 698,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3583), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3583), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 699,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3587), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3586), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 700,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3590), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3590), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 701,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3593), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3593), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 702,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3596), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3596), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 703,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3600), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3599), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 704,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3603), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3602), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 705,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3606), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3606), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 706,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3609), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3609), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 707,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3612), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3612), 7 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 708,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3616), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3615), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 709,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3620), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3620), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 710,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3634), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3634), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 711,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3637), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3637), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 712,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3641), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3640), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 713,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3644), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3644), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 714,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3647), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3647), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 715,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3651), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3650), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 716,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3654), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3654), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 717,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3657), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3657), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 718,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3660), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3660), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 719,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3663), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3663), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 720,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3667), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3666), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 721,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3671), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3671), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 722,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3675), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3674), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 723,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3678), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3678), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 724,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3682), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3681), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 725,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3685), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3685), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 726,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3688), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3688), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 727,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3691), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3691), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 728,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3694), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3694), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 729,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3698), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3697), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 730,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3701), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3701), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 731,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3704), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3704), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 732,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3709), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3709), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 733,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3714), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3714), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 734,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3718), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3717), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 735,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3721), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3721), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 736,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3724), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3724), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 737,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3727), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3727), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 738,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3730), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3730), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 739,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3734), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3733), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 740,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3737), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3737), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 741,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3740), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3740), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 742,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3743), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3743), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 743,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3748), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3747), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 744,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3751), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3751), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 745,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3754), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3754), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 746,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3757), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3757), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 747,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3761), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3760), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 748,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3764), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3763), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 749,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3767), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3767), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 750,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3770), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3770), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 751,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3773), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3773), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 752,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3777), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3776), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 753,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3780), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3780), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 754,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3783), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3783), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 755,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3793), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3793), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 756,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3797), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3796), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 757,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3800), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3800), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 758,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3803), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3803), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 759,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3806), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3806), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 760,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3809), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3809), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 761,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3813), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3812), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 762,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3816), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3816), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 763,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3819), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 764,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3823), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3822), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 765,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3826), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3826), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 766,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3830), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3830), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 767,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3833), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3833), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 768,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3837), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3836), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 769,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3840), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3840), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 770,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3844), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3843), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 771,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3847), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3846), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 772,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3850), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3850), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 773,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3853), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3853), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 774,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3856), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3856), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 775,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3860), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3859), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 776,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3865), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3865), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 777,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3869), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3868), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 778,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3872), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3872), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 779,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3881), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3881), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 780,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3884), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3884), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 781,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3888), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3887), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 782,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3891), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3890), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 783,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3894), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3894), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 784,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3897), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3897), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 785,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3901), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3900), 6 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 786,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3904), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3904), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 787,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3907), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3907), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 788,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3910), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3910), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 789,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3915), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3914), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 790,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3918), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3918), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 791,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3921), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3921), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 792,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3924), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3924), 4 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 793,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3927), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3927), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 794,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3931), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3930), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 795,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3934), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3934), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 796,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3937), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3937), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 797,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3940), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 798,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3945), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3944), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 799,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3948), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3948), 5 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 800,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3951), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3951), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 801,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3954), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3954), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 802,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3958), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3957), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 803,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3961), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3961), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 804,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3964), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3964), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 805,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3967), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3967), 8 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 806,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3971), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3970), 11 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 807,
                columns: new[] { "DeletedDate", "ModifiedDate", "PortionName" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3974), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3974), 8 });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4412), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4414), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4415), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4416), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4417), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4417), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4418), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4418), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4418) });
        }
    }
}
