using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaloriTracker.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initdb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Foods",
                type: "int",
                nullable: true);

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
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4270), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4269), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4345), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4344), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4349), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4349), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4353), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4353), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4358), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4357), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4362), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4361), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4366), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4365), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4369), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4369), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4373), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4372), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4376), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4376), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4380), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4380), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4383), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4383), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4386), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4386), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4390), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4389), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4393), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4393), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4403), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4403), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4406), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4406), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4409), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4409), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4413), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4412), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4416), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4415), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4419), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4419), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4423), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4422), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4426), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4425), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4429), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4429), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4432), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4432), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4435), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4435), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4440), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4439), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4443), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4443), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4446), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4446), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4449), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4449), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4452), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4452), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4456), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4455), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4459), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4459), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4462), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4462), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4466), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4465), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4469), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4468), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4472), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4472), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4476), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4476), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4479), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4479), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4482), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4482), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4486), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4485), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4489), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4488), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4492), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4492), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4501), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4501), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4505), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4504), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4508), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4508), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4512), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4511), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4515), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4515), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4518), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4518), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4522), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4522), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4526), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4525), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4529), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4528), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4532), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4532), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4535), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4535), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4539), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4538), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4542), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4541), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4545), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4545), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4548), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4548), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4551), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4551), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4555), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4555), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4559), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4558), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4562), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4561), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4565), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4565), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4568), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4568), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4571), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4571), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4575), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4574), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4578), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4577), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4581), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4581), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4584), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4587), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4587), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4590), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4590), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4594), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4593), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4598), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4598), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4601), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4601), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4605), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4604), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4608), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4608), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4611), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4611), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4614), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4614), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4618), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4618), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4621), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4621), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4624), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4624), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4627), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4627), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4631), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4631), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4634), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4634), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4637), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4637), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4640), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4640), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4643), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4643), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4647), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4646), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4650), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4650), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4653), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4653), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4656), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4656), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4659), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4659), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4663), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4662), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4666), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4666), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4670), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4669), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4674), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4674), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4677), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4677), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4680), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4680), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4683), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4683), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4687), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4686), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4690), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4690), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4693), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4693), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4696), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4696), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4699), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4699), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4703), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4702), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4706), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4706), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4711), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4711), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4719), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4719), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4723), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4723), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4727), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4726), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4731), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4730), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4741), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4744), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4748), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4748), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4752), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4752), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4756), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4755), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 117,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4759), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4759), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 118,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4763), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4763), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4768), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4767), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4771), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4771), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4774), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4774), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4777), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4781), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4780), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4784), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4784), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4787), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4787), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4790), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4790), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4793), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4793), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4797), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4796), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4800), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4799), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4804), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4804), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4807), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4807), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4810), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4810), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4813), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4813), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4817), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4816), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4820), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4819), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4823), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4823), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4826), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4826), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 138,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4829), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4829), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 139,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4832), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4832), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4835), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4835), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 141,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4838), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4838), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 142,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4843), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4842), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 143,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4846), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4846), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 144,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4849), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4849), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4852), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4852), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4855), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4859), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4858), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4862), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4862), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 149,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4866), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4866), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 150,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4869), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4869), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 151,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4872), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4872), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4875), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4875), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 153,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4880), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4879), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 154,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4883), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4882), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4886), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4886), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4889), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4889), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4892), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4892), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4895), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4895), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4898), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4898), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4902), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4901), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4905), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4905), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4908), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4908), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4911), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4911), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4916), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4916), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 165,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4919), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4919), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4922), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4922), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4925), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4925), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 168,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4928), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4932), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4931), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4935), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4934), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 171,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4938), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4938), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4941), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4941), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4945), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4945), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4948), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4948), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4952), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4951), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4956), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4956), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 177,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4960), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4960), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4963), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4963), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4966), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4966), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4977), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4976), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 181,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4980), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4980), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 182,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4983), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4983), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 183,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4986), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4986), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 184,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4990), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4989), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4993), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4993), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4996), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(4996), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5001), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5000), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 188,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5004), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5004), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5007), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5007), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5011), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5010), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 191,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5014), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5014), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5018), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5018), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5023), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5023), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 194,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5027), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5027), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5030), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5030), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5033), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5033), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5037), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5036), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 198,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5040), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5040), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 199,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5044), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5044), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5048), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5048), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5051), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5051), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5055), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5054), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5058), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5058), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5061), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5061), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5065), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5064), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5068), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5068), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5071), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5071), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5075), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5074), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5078), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5078), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5082), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5082), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5086), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5085), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5089), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5089), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5092), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5092), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5095), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5095), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 215,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5102), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5101), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5105), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5105), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5108), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5108), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5112), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5111), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5115), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5115), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5118), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5118), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5121), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5126), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5126), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5129), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5129), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5132), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5132), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5136), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5135), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5139), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5139), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5142), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5142), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5146), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5145), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5149), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5149), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5152), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5152), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5156), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5155), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5159), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5159), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5163), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5163), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5166), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5166), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5170), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5169), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5173), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5173), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5176), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5176), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5181), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5180), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5184), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5184), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5187), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5187), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 241,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5190), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5190), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 242,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5194), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5193), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 243,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5197), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5197), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5201), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5201), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 245,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5204), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5204), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 246,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5208), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5208), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5211), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5211), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5214), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5214), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5224), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5224), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 250,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5227), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5227), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5231), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5230), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5234), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5234), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 253,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5237), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5237), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 254,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5240), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5240), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 255,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5244), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5243), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 256,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5248), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5248), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5251), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5251), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5254), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5254), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5258), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5257), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5262), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5262), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5266), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5265), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 262,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5269), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5268), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 263,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5272), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5272), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 264,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5275), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5275), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5278), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5278), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 266,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5281), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5281), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 267,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5285), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5285), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5289), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5288), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 269,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5292), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5291), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 270,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5295), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5295), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5298), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5298), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5301), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5301), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5305), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5304), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5308), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5307), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5311), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5311), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5314), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5314), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5317), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5317), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5320), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5320), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5324), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5324), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5328), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5327), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5331), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5330), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 282,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5335), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5335), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5339), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5338), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 284,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5342), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5341), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 285,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5345), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5345), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5348), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5348), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5351), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5351), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5354), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5354), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5357), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5357), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5362), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5362), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5366), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5366), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5370), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5370), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 293,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5374), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5373), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 294,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5377), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5377), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5381), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5381), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5385), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5385), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5389), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5388), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5393), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5392), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5396), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5396), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5400), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5400), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5404), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5404), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5408), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5408), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5411), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5411), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5416), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5416), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5419), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5419), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5422), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5422), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5425), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5425), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5490), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5489), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5494), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5494), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5498), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5498), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5502), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5501), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5505), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5505), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5510), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5510), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5514), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5514), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5518), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5517), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5521), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5521), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5531), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5531), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5535), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5535), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5539), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5539), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5542), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5542), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5546), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5546), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5550), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5550), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5554), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5554), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5559), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5558), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5562), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5562), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5566), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5566), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5570), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5569), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5574), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5573), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5577), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5577), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5581), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5581), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5585), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5585), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5589), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5588), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 333,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5592), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5592), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5596), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5596), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5600), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5600), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5604), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5604), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5608), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5608), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5612), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5611), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5615), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5615), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5619), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5619), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5623), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5622), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5627), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5626), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5630), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5630), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5634), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5634), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5638), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5638), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 346,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5642), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5641), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 347,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5649), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5649), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5653), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5653), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5657), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5657), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5661), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5660), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5665), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5664), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5668), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5668), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5672), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5672), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5676), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5676), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5680), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5679), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5684), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5683), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 357,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5687), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5687), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5692), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5691), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5696), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5695), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5699), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5699), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5703), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5703), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5707), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5707), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5711), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5710), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 364,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5715), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5714), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 365,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5718), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5718), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5722), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5722), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5726), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5726), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5730), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5730), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5734), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5734), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5739), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5739), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5743), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5743), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 372,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5747), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5747), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 373,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5751), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5751), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5755), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5754), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5758), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5758), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5762), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5762), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5766), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5766), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5769), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5769), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 379,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5773), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5773), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 380,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5777), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5777), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5782), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5781), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 382,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5785), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5785), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 383,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5789), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5789), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5793), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5793), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 385,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5803), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5802), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 386,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5807), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5806), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5810), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5810), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5814), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5814), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5818), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5818), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5822), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5821), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5825), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5825), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 392,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5829), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5829), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5834), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5833), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5837), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5837), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5841), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5841), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5845), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5844), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5849), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5848), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5852), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5852), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5856), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5856), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5860), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5859), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5863), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5863), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5867), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5867), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5871), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5871), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5875), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5875), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5879), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5879), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5883), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5882), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5886), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5886), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5890), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5890), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5894), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5894), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5898), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5897), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5901), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5901), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5905), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5905), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5909), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5909), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5913), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5912), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5917), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5917), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5921), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5921), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5925), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5924), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5928), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5928), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5932), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5932), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5936), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5935), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5939), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5939), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5943), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5943), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5947), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5947), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5951), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5950), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5954), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5954), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5958), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5958), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5963), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5963), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5967), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5967), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5971), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5970), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5974), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5974), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5978), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5978), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5982), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5982), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 433,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5986), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5985), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5989), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5989), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5993), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5993), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5997), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(5996), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6000), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6000), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6005), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6005), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6009), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6009), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6013), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6013), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6017), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6016), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6020), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6020), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6024), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6024), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6028), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6027), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 445,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6031), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6031), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 446,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6035), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6035), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 447,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6039), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6039), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6043), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6042), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6046), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6046), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6051), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6051), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6055), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6054), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6058), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6058), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6062), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6062), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6072), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6072), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6076), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6076), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6080), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6080), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6084), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6084), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6088), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6087), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6092), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6091), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6095), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6095), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6099), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6099), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6103), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6103), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6107), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6106), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6111), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6110), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6114), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6114), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6118), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6118), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6122), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6122), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6126), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6125), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6129), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6129), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6133), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6133), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6137), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6137), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 472,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6141), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6141), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 473,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6146), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6145), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6150), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6149), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6153), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6153), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6157), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6157), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6161), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6161), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6165), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6164), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6168), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6168), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6172), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6172), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6176), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6176), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6180), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6180), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6184), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6184), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 484,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6188), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6188), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 485,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6191), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6191), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 486,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6195), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6195), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6198), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6198), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6202), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6201), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6205), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6205), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6208), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6208), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6211), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6211), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6214), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6214), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6218), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6217), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6221), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6225), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6229), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6228), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6232), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6231), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6235), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6235), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6238), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6238), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6241), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 501,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6244), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6244), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 502,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6248), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6247), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 503,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6251), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6250), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 504,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6254), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6254), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 505,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6257), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6257), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 506,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6261), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6260), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 507,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6265), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6265), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 508,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6269), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6268), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 509,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6272), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6272), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 510,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6275), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6275), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 511,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6278), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6278), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 512,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6281), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6281), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 513,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6285), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6284), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 514,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6288), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6288), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 515,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6291), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6291), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 516,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6294), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6294), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 517,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6297), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 518,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6302), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6302), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 519,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6305), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6305), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 520,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6308), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6308), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 521,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6312), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6311), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 522,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6321), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6321), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 523,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6325), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6324), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 524,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6328), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6328), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 525,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6331), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6331), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 526,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6334), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6334), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 527,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6338), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6337), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 528,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6341), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6341), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 529,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6344), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6344), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 530,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6354), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6354), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 531,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6357), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6357), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 532,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6361), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6360), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 533,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6364), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6364), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 534,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6367), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6367), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 535,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6370), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6370), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 536,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6373), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6373), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 537,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6376), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6376), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 538,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6380), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6380), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 539,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6383), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6383), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 540,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6386), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6386), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 541,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6391), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6390), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 542,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6394), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6394), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 543,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6397), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6397), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 544,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6400), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6400), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 545,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6404), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6403), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 546,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6407), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6407), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 547,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6410), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6410), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 548,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6413), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6413), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 549,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6416), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6416), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 550,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6420), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6419), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 551,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6423), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6423), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 552,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6430), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6430), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 553,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6433), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6433), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 554,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6436), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6436), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 555,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6439), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6439), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 556,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6442), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6442), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 557,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6445), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6445), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 558,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6449), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6448), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 559,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6452), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6451), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 560,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6455), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6455), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 561,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6458), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6458), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 562,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6461), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6461), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 563,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6464), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6464), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 564,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6468), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6468), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 565,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6472), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6471), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 566,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6475), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6474), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 567,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6478), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6478), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 568,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6481), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6481), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 569,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6485), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6484), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 570,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6488), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6487), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 571,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6491), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6491), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 572,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6494), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6494), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 573,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6498), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6497), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 574,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6501), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6501), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 575,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6505), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6505), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 576,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6508), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6508), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 577,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6511), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6511), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 578,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6514), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6514), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 579,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6518), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6517), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 580,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6521), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6520), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 581,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6524), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6524), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 582,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6527), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6527), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 583,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6530), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6530), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 584,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6533), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6533), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 585,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6536), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6536), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 586,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6540), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6539), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 587,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6544), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6543), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 588,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6547), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6546), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 589,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6550), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 590,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6560), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6560), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 591,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6563), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6563), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 592,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6567), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6567), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 593,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6570), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6570), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 594,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6573), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6573), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 595,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6577), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6576), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 596,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6580), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6580), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 597,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6583), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6583), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 598,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6593), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6593), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 599,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6596), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6596), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 600,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6600), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6599), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 601,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6603), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6603), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 602,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6606), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6606), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 603,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6609), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6609), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 604,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6613), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6612), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 605,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6616), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6616), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 606,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6619), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6619), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 607,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6622), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6622), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 608,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6626), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6625), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 609,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6630), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6629), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 610,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6633), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6633), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 611,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6636), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6636), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 612,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6639), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6639), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 613,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6643), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6642), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 614,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6646), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6645), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 615,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6649), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6649), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 616,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6652), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6652), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 617,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6655), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 618,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6659), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6658), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 619,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6662), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6661), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 620,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6667), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6666), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 621,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6670), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6669), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 622,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6673), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6673), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 623,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6676), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6676), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 624,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6680), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6679), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 625,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6683), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6683), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 626,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6686), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6686), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 627,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6689), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6689), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 628,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6692), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6692), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 629,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6695), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6695), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 630,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6698), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6698), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 631,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6702), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6701), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 632,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6706), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6705), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 633,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6709), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6709), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 634,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6712), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6712), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 635,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6715), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6715), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 636,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6718), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6718), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 637,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6722), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6721), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 638,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6725), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6725), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 639,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6728), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6728), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 640,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6731), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6731), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 641,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6734), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6734), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 642,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6738), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6737), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 643,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6743), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6743), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 644,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6747), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6746), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 645,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6750), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6749), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 646,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6753), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6753), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 647,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6756), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6756), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 648,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6760), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6759), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 649,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6763), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6762), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 650,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6766), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6766), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 651,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6769), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6769), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 652,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6772), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6772), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 653,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6775), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6775), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 654,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6779), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6778), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 655,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6784), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6783), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 656,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6787), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6787), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 657,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6791), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6791), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 658,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6795), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6795), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 659,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6805), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6805), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 660,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6809), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6808), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 661,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6812), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6812), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 662,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6816), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6816), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 663,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6820), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6820), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 664,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6824), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6823), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 665,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6828), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6827), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 666,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6832), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6832), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 667,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6836), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6835), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 668,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6839), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6839), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 669,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6842), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6842), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 670,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6845), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6845), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 671,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6848), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 672,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6852), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6851), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 673,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6855), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6855), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 674,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6858), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6858), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 675,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6861), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6861), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 676,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6864), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6864), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 677,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6868), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6867), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 678,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6872), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6872), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 679,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6875), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6875), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 680,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6879), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6878), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 681,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6882), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6881), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 682,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6885), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6884), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 683,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6888), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6888), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 684,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6891), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6891), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 685,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6895), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6894), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 686,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6898), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6898), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 687,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6902), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6902), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 688,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6905), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6905), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 689,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6909), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6908), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 690,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6912), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6911), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 691,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6915), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6915), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 692,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6918), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6918), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 693,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6921), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6921), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 694,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6924), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6924), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 695,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6928), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6927), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 696,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6930), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 697,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6934), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6934), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 698,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6937), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6937), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 699,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6940), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6940), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 700,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6943), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6943), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 701,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6948), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6947), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 702,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6951), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6950), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 703,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6954), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6954), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 704,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6957), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6957), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 705,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6960), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6960), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 706,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6963), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6963), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 707,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6966), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6966), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 708,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6970), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6969), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 709,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6972), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 710,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6976), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6976), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 711,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6979), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6979), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 712,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6983), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6983), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 713,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6987), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6986), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 714,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6990), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6989), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 715,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6993), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6993), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 716,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6996), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6996), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 717,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6999), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(6999), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 718,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7002), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7002), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 719,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7005), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7005), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 720,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7008), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7008), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 721,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7012), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7011), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 722,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7015), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7014), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 723,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7018), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7018), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 724,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7023), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7022), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 725,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7026), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7026), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 726,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7029), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7029), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 727,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7039), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7038), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 728,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7042), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7042), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 729,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7045), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7045), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 730,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7048), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7048), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 731,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7051), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7051), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 732,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7055), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7055), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 733,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7058), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7058), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 734,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7061), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7061), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 735,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7065), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7065), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 736,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7068), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7068), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 737,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7072), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7071), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 738,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7075), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 739,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7078), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 740,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7081), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 741,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7084), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 742,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7088), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7087), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 743,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7091), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 744,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7094), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7094), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 745,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7097), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7097), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 746,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7102), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7101), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 747,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7105), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7105), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 748,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7109), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7108), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 749,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7112), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7112), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 750,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7115), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7115), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 751,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7118), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7118), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 752,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7121), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7121), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 753,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7125), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7124), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 754,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7128), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7127), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 755,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7131), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7131), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 756,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7135), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 757,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7138), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7138), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 758,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7141), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7141), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 759,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7145), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7144), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 760,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7148), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7147), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 761,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7151), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7151), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 762,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7154), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7154), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 763,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7157), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7157), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 764,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7161), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7160), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 765,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7164), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7164), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 766,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7167), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7167), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 767,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7170), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 768,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7173), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7173), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 769,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7177), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 770,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7181), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7180), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 771,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7184), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7184), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 772,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7187), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7187), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 773,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7190), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7190), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 774,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7193), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 775,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7197), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7196), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 776,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7200), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7200), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 777,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7204), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7203), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 778,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7207), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7206), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 779,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7210), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7210), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 780,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7213), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7213), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 781,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7217), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7217), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 782,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7220), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7220), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 783,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7224), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7223), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 784,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7227), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7227), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 785,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7230), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7230), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 786,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7233), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7233), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 787,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7236), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7236), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 788,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7240), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7239), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 789,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7243), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7243), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 790,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7246), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7246), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 791,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7249), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7249), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 792,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7254), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7253), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 793,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7257), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7256), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 794,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7260), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7260), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 795,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7268), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7268), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 796,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7272), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7271), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 797,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7275), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7275), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 798,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7278), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7278), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 799,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7281), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7281), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 800,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7284), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7284), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 801,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7287), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7287), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 802,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7291), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7291), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 803,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7294), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7294), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 804,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7297), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7297), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 805,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7300), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7300), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 806,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7303), null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 807,
                columns: new[] { "DeletedDate", "ModifiedDate", "UserID" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7307), new DateTime(2024, 3, 26, 17, 17, 17, 237, DateTimeKind.Local).AddTicks(7306), null });

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

            migrationBuilder.CreateIndex(
                name: "IX_Foods_UserID",
                table: "Foods",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Users_UserID",
                table: "Foods",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Users_UserID",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_UserID",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Foods");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 558, DateTimeKind.Local).AddTicks(8412), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 558, DateTimeKind.Local).AddTicks(8427), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 558, DateTimeKind.Local).AddTicks(8428), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 558, DateTimeKind.Local).AddTicks(8429), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 558, DateTimeKind.Local).AddTicks(8430), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 558, DateTimeKind.Local).AddTicks(8431), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 558, DateTimeKind.Local).AddTicks(8431), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 558, DateTimeKind.Local).AddTicks(8432), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 558, DateTimeKind.Local).AddTicks(8433), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 558, DateTimeKind.Local).AddTicks(8434), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 558, DateTimeKind.Local).AddTicks(8435), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 558, DateTimeKind.Local).AddTicks(8435), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 558, DateTimeKind.Local).AddTicks(8436), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 558, DateTimeKind.Local).AddTicks(8437), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 558, DateTimeKind.Local).AddTicks(8437), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 117,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 118,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 138,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 139,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 141,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 142,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 143,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 144,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 149,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 150,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 151,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 153,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 154,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 165,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 168,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 171,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 177,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 181,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 182,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 183,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 184,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 188,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 191,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 194,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 198,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 199,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 215,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 241,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 242,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 243,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 245,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 246,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 250,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 253,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 254,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 255,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 256,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 262,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 263,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 264,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 266,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 267,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 269,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 270,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 282,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 284,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 285,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 293,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 294,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 333,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 346,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 347,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 357,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 364,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 365,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 372,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 373,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 379,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 380,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 382,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 383,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 385,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 386,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 392,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 433,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 445,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 446,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 447,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 472,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 473,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 484,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 485,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 486,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 501,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 502,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 503,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 504,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 505,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 506,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 507,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 508,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 509,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 510,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 511,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 512,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 513,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 514,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 515,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 516,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 517,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 518,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 519,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 520,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 521,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 522,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 523,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 524,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 525,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 526,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 527,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 528,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 529,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 530,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 531,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 532,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 533,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 534,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 535,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 536,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 537,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 538,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 539,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 540,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 541,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 542,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 543,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 544,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 545,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 546,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 547,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 548,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 549,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 550,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 551,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 552,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 553,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 554,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 555,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 556,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 557,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 558,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 559,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 560,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 561,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 562,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 563,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 564,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 565,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 566,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 567,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 568,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 569,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 570,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 571,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 572,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 573,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 574,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 575,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 576,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 577,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 578,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 579,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 580,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 581,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 582,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 583,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 584,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 585,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 586,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 587,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 588,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 589,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 590,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 591,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 592,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 593,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 594,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 595,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 596,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 597,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 598,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 599,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 600,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 601,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 602,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 603,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 604,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 605,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 606,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 607,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 608,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 609,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 610,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 611,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 612,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 613,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 614,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 615,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 616,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 617,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 618,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 619,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 620,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 621,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 622,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 623,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 624,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 625,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 626,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 627,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 628,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 629,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 630,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 631,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 632,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 633,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 634,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 635,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 636,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 637,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 638,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 639,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 640,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 641,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 642,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 643,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 644,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 645,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 646,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 647,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 648,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 649,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 650,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 651,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 652,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 653,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 654,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 655,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 656,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 657,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 658,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 659,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 660,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 661,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 662,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 663,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 664,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 665,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 666,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 667,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 668,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 669,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 670,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 671,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 672,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 673,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 674,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 675,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 676,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 677,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 678,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 679,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 680,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 681,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 682,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 683,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 684,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 685,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 686,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 687,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 688,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 689,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 690,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 691,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 692,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 693,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 694,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 695,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 696,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 697,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 698,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 699,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 700,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 701,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 702,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 703,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 704,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 705,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 706,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 707,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 708,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 709,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 710,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 711,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 712,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 713,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 714,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 715,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 716,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 717,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 718,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 719,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 720,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 721,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 722,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 723,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 724,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 725,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 726,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 727,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 728,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 729,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 730,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 731,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 732,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 733,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 734,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 735,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 736,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 737,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 738,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 739,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 740,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 741,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 742,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 743,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 744,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 745,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 746,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 747,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 748,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 749,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 750,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 751,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 752,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 753,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 754,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 755,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 756,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 757,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 758,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 759,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 760,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 761,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 762,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 763,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 764,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 765,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 766,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 767,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 768,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 769,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 770,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 771,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 772,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 773,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 774,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 775,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 776,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 777,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 778,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 779,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 780,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 781,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 782,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 783,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 784,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 785,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 786,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 787,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 788,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 789,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 790,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 791,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 792,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 793,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 794,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 795,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 796,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 797,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 798,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 799,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 800,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 801,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 802,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 803,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 804,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 805,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 806,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 807,
                columns: new[] { "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 559, DateTimeKind.Local).AddTicks(1140), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 559, DateTimeKind.Local).AddTicks(1141), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 559, DateTimeKind.Local).AddTicks(1142), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreationDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 48, 44, 559, DateTimeKind.Local).AddTicks(1143), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
