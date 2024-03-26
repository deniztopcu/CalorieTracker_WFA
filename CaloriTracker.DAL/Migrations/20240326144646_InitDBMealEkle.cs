using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaloriTracker.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDBMealEkle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Meals",
                type: "int",
                nullable: true);

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
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(253), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(324), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(329), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(333), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(336), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(340), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(344), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(348), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(351), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(355), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(358), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(361), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(366), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(369), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(372), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(376), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(379), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(382), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(386), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(389), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(392), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(395), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(399), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(403), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(407), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(410), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(419), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(423), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(427), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(430), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(434), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(437), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(440), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(444), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(447), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(451), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(455), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(458), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(461), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(465), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(468), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(471), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(474), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(478), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(481), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(484), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(489), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(492), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(495), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(498), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(504), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(507), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(511), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(514), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(517), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(521), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(524), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(527), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(531), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(534), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(541), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(544), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(547), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(551), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(554), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(560), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(563), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(568), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(571), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(574), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(577), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(583), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(586), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(589), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(592), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(596), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(599), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(602), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(605), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(610), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(613), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(617), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(620), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(623), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(626), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(630), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(633), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(636), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(639), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(643), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(647), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(650), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(707), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(712), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(717), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(723), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(728), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(733), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(739), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(744), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(750), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(756), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(762), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(767), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(777), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(782), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(787), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(792), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(797), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(802), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(807), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(813), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 117,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(825), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 118,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(830), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(836), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(841), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(845), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(850), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(854), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(854) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(859), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(864), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(868), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(875), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(880), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(885), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(889), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(894), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(899), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(903), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(908), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(913), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(918), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(924), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 138,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 139,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(937), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(942), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 141,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(948), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 142,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(954), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 143,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(959), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 144,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(964), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(970), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(976), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(981), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(987), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 149,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(993), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 150,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1000), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 151,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1006), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1012), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 153,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1017), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 154,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1023), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1028), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1032), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1037), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1042), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1047), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1054), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1060), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1065), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1070), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1083), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 165,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1089), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1094), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1099), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 168,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1104), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1109), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1115), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 171,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1120), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1124), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1131), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1136), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1142), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1148), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 177,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1154), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1165), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1170), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 181,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1175), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 182,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1181), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 183,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1186), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 184,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1192), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1198), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1204), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1210), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 188,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1216), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1221), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1227), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 191,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1232), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1237), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1243), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 194,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1248), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1254), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1261), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1266), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 198,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1272), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 199,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1278), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1285), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1291), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1296), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1301), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1307), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1312), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1318), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1325), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1331), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1337), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1342), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1349), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1354), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1362), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1367), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 215,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1373), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1379), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1384), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1391), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1396), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1402), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1408), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1413), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1420), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1425), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1431), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1436), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1444), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1450), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1455), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1462), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1468), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1479), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1485), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1491), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1497), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1503), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1508), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1513), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1519), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1524), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 241,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1531), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 242,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1536), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 243,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1542), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1548), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 245,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1553), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 246,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1559), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1565), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1570), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1576), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 250,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1582), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1587), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1592), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 253,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1600), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 254,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1605), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 255,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1610), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 256,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1615), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1620), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1625), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1629), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1635), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1640), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 262,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1646), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 263,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1652), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 264,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1659), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1665), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 266,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1670), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 267,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1676), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1682), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 269,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1687), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 270,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1692), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1697), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1701), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1706), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1711), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1717), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1724), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1730), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1735), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1741), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1746), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1753), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 282,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1759), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1764), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 284,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1770), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 285,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1776), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1782), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1788), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1793), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1799), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1805), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1810), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1816), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 293,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1821), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 294,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1827), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1833), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1839), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1844), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1851), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1857), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1868), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1874), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1880), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1886), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1892), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1897), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1903), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1908), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1915), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1921), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1928), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1933), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1939), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1945), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1950), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1955), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1962), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1968), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1973), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1979), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1985), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1996), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2002), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2008), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2014), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2019), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2024), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2029), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2034), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2038), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2044), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2049), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2054), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 333,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2060), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2066), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2071), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2076), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2081), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2086), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2091), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2096), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2101), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2106), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2111), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2118), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2123), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 346,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2128), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 347,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2133), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2139), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2144), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2149), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2154), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2159), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2164), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2169), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2176), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2180), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 357,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2187), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2192), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2195), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2199), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2202), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2205), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2209), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 364,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2212), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 365,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2215), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2218), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2224), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2227), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2236), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2239), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2242), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 372,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2246), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 373,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2249), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2252), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2255), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2258), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2262), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2266), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 379,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2269), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 380,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2272), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2276), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 382,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2279), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 383,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2282), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2285), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 385,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2289), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 386,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2292), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2295), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2298), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2302), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2306), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2309), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 392,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2312), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2316), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2319), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2322), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2326), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2329), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2403), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2411), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2414), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2419), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2422), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2425), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2429), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2432), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2435), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2438), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2441), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2445), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2448), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2451), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2456), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2459), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2463), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2466), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2469), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2473), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2476), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2479), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2482), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2485), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2489), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2492), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2496), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2500), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2503), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2506), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2510), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2513), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2516), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2520), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2523), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 433,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2526), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2529), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2540), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2543), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2551), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2555), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2558), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2561), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2565), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2568), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2571), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2574), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 445,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2578), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 446,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2581), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 447,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2585), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2589), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2592), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2595), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2598), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2602), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2605), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2608), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2611), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2616), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2620), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2623), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2626), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2630), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2633), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2636), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2639), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2643), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2646), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2649), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2722), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2725), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2729), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2733), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2737), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 472,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2786), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 473,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2792), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2796), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2800), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2803), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2807), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2811), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2815), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2818), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2823), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2826), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2830), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 484,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2833), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 485,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2836), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 486,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2839), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2843), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2846), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2849), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2852), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2856), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2860), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2863), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2867), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2870), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2873), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2876), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2880), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2883), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2886), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 501,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2889), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 502,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2892), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 503,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2896), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 504,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2900), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 505,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2909), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 506,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2912), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 507,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2915), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 508,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2918), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 509,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2922), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 510,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2925), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 511,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2928), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 512,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2932), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 513,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2935), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 514,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2938), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 515,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2943), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 516,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2946), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 517,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2949), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 518,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2953), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 519,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2956), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 520,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2959), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 521,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2962), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 522,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2965), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 523,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2969), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 524,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2972), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 525,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2975), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 526,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2979), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 527,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2984), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 528,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2987), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 529,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2990), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 530,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2993), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 531,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2997), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 532,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3000), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 533,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3003), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 534,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3007), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 535,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3010), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 536,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3013), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 537,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3017), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 538,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3022), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 539,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3025), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 540,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3029), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 541,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3032), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 542,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3035), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 543,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3039), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 544,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3042), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 545,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3045), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 546,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3048), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 547,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3052), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 548,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3055), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 549,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3059), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 550,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3062), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 551,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3065), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 552,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3069), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 553,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3072), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 554,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3075), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 555,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3078), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 556,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3083), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3083) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 557,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3086), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 558,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3090), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 559,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3093), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 560,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 561,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3101), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 562,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3104), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 563,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3108), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 564,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3111), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 565,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3114), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 566,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3117), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 567,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3120), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 568,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3124), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 569,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3127), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 570,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3130), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 571,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3134), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 572,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3138), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 573,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3141), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 574,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3150), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 575,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3154), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 576,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3157), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 577,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3162), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 578,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3166), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 579,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3169), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 580,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3172), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 581,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3175), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 582,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3179), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 583,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3182), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 584,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3186), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 585,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3189), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 586,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3193), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 587,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3196), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 588,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3199), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 589,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3203), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 590,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3206), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 591,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3209), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 592,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3213), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 593,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3216), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 594,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3219), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 595,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3223), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 596,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3227), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 597,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3230), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 598,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3234), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 599,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3238), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 600,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3242), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 601,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3245), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 602,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3248), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 603,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3251), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 604,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3255), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 605,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3258), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 606,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3262), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 607,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3265), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 608,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3269), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 609,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3272), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 610,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3276), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 611,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3279), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 612,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3282), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 613,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3285), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 614,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3288), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 615,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3291), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 616,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3295), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 617,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3298), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 618,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3303), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 619,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3306), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 620,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3309), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 621,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3312), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 622,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3317), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 623,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3320), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 624,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3324), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 625,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3327), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 626,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3330), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 627,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3333), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 628,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3337), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 629,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3341), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 630,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3344), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 631,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3347), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 632,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3350), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 633,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3354), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 634,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3357), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 635,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3360), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 636,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3363), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 637,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3366), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 638,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3370), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 639,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3373), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 640,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3376), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 641,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3381), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 642,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3390), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 643,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3393), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 644,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3396), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 645,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3399), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 646,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3403), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 647,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3406), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 648,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3409), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 649,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3412), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 650,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3415), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 651,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3419), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 652,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3423), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 653,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3427), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 654,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3431), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 655,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3434), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 656,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3438), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 657,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3442), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 658,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3446), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 659,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3449), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 660,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3453), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 661,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3457), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 662,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3461), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 663,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 664,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3469), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 665,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3472), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 666,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3476), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 667,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3479), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 668,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3482), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 669,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3485), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 670,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3488), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 671,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3492), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 672,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3495), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 673,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3498), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 674,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3502), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 675,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3506), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 676,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3509), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 677,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3512), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 678,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3516), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 679,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3519), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 680,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3522), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 681,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3525), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 682,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3529), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 683,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3532), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 684,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3535), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 685,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3538), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 686,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3543), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 687,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3546), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 688,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3549), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 689,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3553), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 690,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3556), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 691,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3560), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 692,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3563), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 693,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3566), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 694,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3569), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 695,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3572), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 696,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3576), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 697,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3579), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 698,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3583), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 699,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3587), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 700,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3590), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 701,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3593), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 702,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3596), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 703,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3600), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 704,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3603), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 705,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3606), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 706,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3609), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 707,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3612), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 708,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3616), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 709,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3620), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 710,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3634), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 711,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3637), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 712,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3641), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 713,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3644), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 714,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3647), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 715,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3651), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 716,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3654), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 717,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3657), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 718,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3660), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 719,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3663), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 720,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3667), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 721,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3671), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 722,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3675), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 723,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3678), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 724,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3682), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 725,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3685), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 726,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3688), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 727,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3691), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 728,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3694), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 729,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3698), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 730,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3701), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 731,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3704), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 732,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3709), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 733,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3714), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 734,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3718), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 735,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3721), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 736,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3724), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 737,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3727), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 738,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3730), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 739,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3734), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 740,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3737), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 741,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3740), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 742,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3743), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3743) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 743,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3748), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 744,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3751), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 745,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3754), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 746,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3757), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 747,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3761), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 748,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3764), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 749,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3767), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 750,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3770), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 751,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3773), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 752,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3777), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 753,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3780), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 754,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3783), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 755,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3793), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 756,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3797), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 757,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3800), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 758,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3803), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 759,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3806), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 760,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3809), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 761,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3813), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 762,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3816), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 763,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 764,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3823), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 765,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3826), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 766,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3830), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 767,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3833), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 768,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3837), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 769,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3840), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 770,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3844), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 771,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3847), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 772,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3850), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 773,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3853), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 774,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3856), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 775,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3860), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 776,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3865), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 777,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3869), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 778,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3872), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 779,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3881), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 780,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3884), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 781,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3888), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 782,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3891), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 783,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3894), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 784,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3897), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 785,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3901), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 786,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3904), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 787,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3907), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 788,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3910), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 789,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3915), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 790,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3918), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 791,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3921), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 792,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3924), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 793,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3927), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 794,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3931), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 795,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3934), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 796,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3937), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 797,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 798,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3945), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 799,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3948), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 800,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3951), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 801,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3954), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 802,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3958), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 803,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3961), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 804,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3964), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 805,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3967), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 806,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3971), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 807,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3974), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4412), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4414), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4414), null });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4415), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4416), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4415), null });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4417), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4417), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4417), null });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4418), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4418), new DateTime(2024, 3, 26, 17, 46, 45, 122, DateTimeKind.Local).AddTicks(4418), null });

            migrationBuilder.CreateIndex(
                name: "IX_Meals_UserID",
                table: "Meals",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Users_UserID",
                table: "Meals",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Users_UserID",
                table: "Meals");

            migrationBuilder.DropIndex(
                name: "IX_Meals_UserID",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Meals");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4074), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4092), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4093), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4094), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4095), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4096), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4096), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4097), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4098), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4098), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4099), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4100), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4100), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4101), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4102), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4102), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4103), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4104), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4104), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4105), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4106), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4106), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4107), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4108), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4108), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4109), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4110), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4110), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4111), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4111), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4270), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4345), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4349), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4353), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4358), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4362), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4366), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4369), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4373), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4376), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4380), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4383), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4386), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4390), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4393), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4403), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4406), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4409), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4413), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4416), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4419), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4423), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4426), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4429), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4432), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4435), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4440), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4443), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4446), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4449), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4452), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4456), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4459), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4462), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4466), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4469), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4472), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4476), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4479), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4482), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4486), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4489), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4492), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4501), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4505), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4508), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4512), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4515), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4518), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4522), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4526), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4529), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4532), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4535), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4539), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4542), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4545), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4548), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4551), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4555), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4559), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4562), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4565), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4568), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4571), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4575), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4578), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4581), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4587), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4590), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4594), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4598), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4601), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4605), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4608), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4611), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4614), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4618), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4621), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4624), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4627), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4631), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4634), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4637), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4640), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4643), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4647), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4650), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4653), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4656), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4659), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4663), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4666), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4670), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4674), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4677), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4680), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4683), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4687), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4690), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4693), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4696), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4699), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4703), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4706), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4711), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4719), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4723), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4727), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4731), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4748), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4752), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4756), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 117,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4759), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 118,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4763), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4768), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4771), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4774), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4781), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4784), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4787), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4790), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4793), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4797), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4800), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4804), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4807), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4810), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4813), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4817), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4820), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4823), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4826), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 138,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4829), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 139,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4832), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4835), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 141,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4838), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 142,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4843), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 143,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4846), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 144,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4849), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4852), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4859), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4862), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 149,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4866), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 150,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4869), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 151,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4872), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4875), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 153,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4880), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 154,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4883), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4886), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4889), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4892), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4895), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4898), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4902), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4905), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4908), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4911), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4916), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 165,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4919), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4922), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4925), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 168,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4932), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4935), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 171,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4938), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4941), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4945), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4948), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4952), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4956), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 177,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4960), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4963), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4966), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4977), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 181,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4980), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 182,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4983), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 183,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4986), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 184,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4990), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4993), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4996), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5001), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 188,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5004), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5007), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5011), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 191,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5014), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5018), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5023), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 194,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5027), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5030), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5033), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5037), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 198,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5040), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 199,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5044), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5048), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5051), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5055), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5058), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5061), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5065), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5068), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5071), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5075), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5078), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5082), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5086), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5089), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5092), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5095), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 215,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5102), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5105), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5108), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5112), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5115), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5118), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5126), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5129), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5132), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5136), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5139), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5142), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5146), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5149), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5152), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5156), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5159), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5163), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5166), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5170), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5173), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5176), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5181), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5184), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5187), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 241,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5190), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 242,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5194), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 243,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5197), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5201), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 245,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5204), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 246,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5208), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5211), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5214), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5224), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 250,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5227), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5231), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5234), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 253,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5237), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 254,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5240), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 255,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5244), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 256,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5248), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5251), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5254), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5258), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5262), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5266), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 262,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5269), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 263,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5272), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 264,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5275), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5278), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 266,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5281), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 267,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5285), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5289), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 269,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5292), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 270,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5295), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5298), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5301), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5305), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5308), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5311), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5314), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5317), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5320), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5324), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5331), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 282,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5335), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5339), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 284,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5342), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 285,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5345), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5348), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5351), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5354), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5357), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5362), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5366), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5370), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 293,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5374), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 294,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5377), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5381), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5385), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5389), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5393), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5396), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5400), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5404), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5408), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5411), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5416), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5419), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5422), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5425), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5490), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5494), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5498), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5502), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5505), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5510), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5514), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5518), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5521), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5531), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5535), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5539), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5542), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5546), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5550), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5554), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5559), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5562), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5566), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5570), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5574), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5577), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5581), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5585), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5589), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 333,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5592), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5596), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5600), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5604), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5608), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5612), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5615), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5619), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5623), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5627), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5630), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5634), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5638), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 346,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5642), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 347,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5649), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5653), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5657), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5661), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5665), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5668), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5672), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5676), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5680), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5684), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 357,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5687), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5692), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5696), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5699), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5703), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5707), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5711), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 364,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5715), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 365,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5718), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5722), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5726), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5730), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5734), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5739), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5743), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 372,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5747), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 373,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5751), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5755), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5758), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5762), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5766), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5769), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 379,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5773), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 380,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5777), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5782), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 382,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5785), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 383,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5789), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5793), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 385,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5803), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 386,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5807), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5810), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5814), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5818), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5822), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5825), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 392,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5829), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5834), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5837), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5841), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5845), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5849), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5852), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5856), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5860), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5863), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5867), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5871), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5875), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5879), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5883), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5886), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5890), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5894), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5898), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5901), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5905), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5909), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5913), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5917), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5921), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5925), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5928), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5932), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5936), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5939), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5943), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5947), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5951), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5954), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5958), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5963), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5967), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5971), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5974), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5978), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5982), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 433,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5986), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5989), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5993), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5997), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6000), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6005), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6009), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6013), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6017), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6020), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6024), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6028), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 445,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6031), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 446,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6035), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 447,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6039), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6043), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6046), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6051), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6055), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6058), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6062), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6072), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6076), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6080), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6084), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6088), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6092), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6095), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6099), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6103), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6107), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6111), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6114), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6118), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6122), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6126), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6129), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6133), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6137), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 472,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6141), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 473,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6146), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6150), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6153), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6157), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6161), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6165), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6168), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6172), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6176), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6180), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6184), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 484,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6188), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 485,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6191), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 486,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6195), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6198), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6202), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6205), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6208), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6211), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6214), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6218), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6229), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6232), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6235), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6238), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 501,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6244), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 502,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6248), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 503,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6251), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 504,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6254), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 505,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6257), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 506,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6261), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 507,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6265), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 508,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6269), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 509,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6272), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 510,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6275), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 511,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6278), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 512,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6281), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 513,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6285), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 514,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6288), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 515,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6291), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 516,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6294), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 517,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 518,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6302), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 519,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6305), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 520,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6308), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 521,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6312), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 522,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6321), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 523,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6325), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 524,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6328), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 525,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6331), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 526,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6334), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 527,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6338), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 528,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6341), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 529,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6344), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 530,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6354), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 531,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6357), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 532,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6361), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 533,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6364), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 534,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6367), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 535,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6370), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 536,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6373), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 537,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6376), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 538,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6380), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 539,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6383), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 540,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6386), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 541,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6391), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 542,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6394), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 543,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6397), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 544,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6400), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 545,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6404), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 546,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6407), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 547,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6410), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 548,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6413), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 549,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6416), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 550,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6420), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 551,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6423), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 552,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6430), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 553,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6433), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 554,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6436), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 555,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6439), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 556,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6442), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 557,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6445), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 558,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6449), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 559,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6452), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 560,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6455), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 561,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6458), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 562,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6461), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 563,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6464), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 564,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6468), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 565,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6472), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 566,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6475), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 567,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6478), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 568,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6481), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 569,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6485), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 570,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6488), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 571,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6491), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 572,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6494), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 573,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6498), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 574,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6501), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 575,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6505), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 576,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6508), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 577,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6511), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 578,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6514), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 579,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6518), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 580,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6521), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 581,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6524), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 582,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6527), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 583,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6530), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 584,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6533), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 585,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6536), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 586,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6540), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 587,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6544), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 588,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6547), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 589,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 590,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6560), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 591,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6563), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 592,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6567), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 593,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6570), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 594,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6573), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 595,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6577), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 596,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6580), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 597,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6583), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 598,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6593), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 599,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6596), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 600,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6600), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 601,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6603), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 602,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6606), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 603,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6609), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 604,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6613), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 605,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6616), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 606,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6619), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 607,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6622), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 608,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6626), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 609,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6630), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 610,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6633), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 611,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6636), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 612,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6639), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 613,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6643), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 614,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6646), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 615,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6649), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 616,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6652), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 617,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 618,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6659), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 619,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6662), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 620,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6667), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 621,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6670), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 622,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6673), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 623,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6676), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 624,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6680), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 625,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6683), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 626,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6686), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 627,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6689), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 628,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6692), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 629,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6695), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 630,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6698), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 631,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6702), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 632,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6706), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 633,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6709), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 634,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6712), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 635,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6715), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 636,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6718), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 637,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6722), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 638,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6725), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 639,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6728), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 640,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6731), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 641,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6734), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 642,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6738), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 643,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6743), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 644,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6747), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 645,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6750), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 646,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6753), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 647,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6756), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 648,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6760), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 649,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6763), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 650,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6766), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 651,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6769), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 652,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6772), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 653,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6775), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 654,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6779), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 655,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6784), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 656,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6787), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 657,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6791), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 658,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6795), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 659,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6805), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 660,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6809), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 661,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6812), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 662,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6816), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 663,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6820), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 664,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6824), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 665,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6828), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 666,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6832), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 667,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6836), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 668,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6839), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 669,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6842), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 670,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6845), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 671,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 672,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6852), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 673,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6855), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 674,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6858), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 675,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6861), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 676,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6864), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 677,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6868), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 678,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6872), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 679,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6875), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 680,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6879), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6878) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 681,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6882), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 682,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6885), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 683,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6888), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 684,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6891), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 685,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6895), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 686,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6898), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 687,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6902), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 688,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6905), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 689,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6909), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 690,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6912), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 691,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6915), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 692,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6918), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 693,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6921), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 694,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6924), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 695,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6928), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 696,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 697,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6934), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 698,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6937), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 699,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6940), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 700,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6943), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 701,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6948), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 702,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6951), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 703,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6954), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 704,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6957), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 705,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6960), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 706,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6963), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 707,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6966), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 708,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6970), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 709,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 710,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6976), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 711,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6979), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 712,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6983), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 713,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6987), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 714,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6990), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 715,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6993), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 716,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6996), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 717,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6999), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 718,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7002), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 719,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7005), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 720,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7008), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 721,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7012), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 722,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7015), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 723,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7018), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 724,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7023), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 725,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7026), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 726,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7029), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 727,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7039), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 728,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7042), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 729,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7045), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 730,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7048), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 731,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7051), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 732,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7055), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 733,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7058), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 734,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7061), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 735,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7065), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 736,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7068), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 737,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7072), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 738,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 739,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 740,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 741,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 742,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7088), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 743,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 744,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7094), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 745,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7097), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 746,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7102), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 747,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7105), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 748,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7109), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 749,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7112), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 750,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7115), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 751,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7118), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 752,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7121), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 753,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7125), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 754,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7128), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 755,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7131), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 756,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 757,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7138), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 758,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7141), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 759,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7145), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 760,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7148), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 761,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7151), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 762,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7154), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 763,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7157), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 764,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7161), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 765,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7164), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 766,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7167), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 767,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 768,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7173), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 769,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 770,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7181), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 771,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7184), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 772,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7187), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 773,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7190), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 774,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 775,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7197), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 776,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7200), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 777,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7204), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 778,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7207), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 779,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7210), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 780,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7213), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 781,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7217), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 782,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7220), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 783,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7224), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 784,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7227), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 785,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7230), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 786,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7233), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 787,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7236), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 788,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7240), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 789,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7243), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 790,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7246), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 791,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7249), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 792,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7254), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 793,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7257), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 794,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7260), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 795,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7268), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 796,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7272), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 797,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7275), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 798,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7278), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 799,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7281), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 800,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7284), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 801,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7287), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 802,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7291), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 803,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7294), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 804,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7297), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 805,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7300), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 806,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 807,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7307), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7731), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7732), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7733), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7733), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7734), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7735), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7734) });
        }
    }
}
