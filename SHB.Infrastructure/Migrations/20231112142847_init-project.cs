using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SHB.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initproject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6283), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6285), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6287), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "FieldOfStudy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6299), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "FieldOfStudy",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6302), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "FieldOfStudy",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6303), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "FieldOfStudy",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6305), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "FieldOfStudy",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6306), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "Program",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6319), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Program",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6322), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Program",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6323), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Program",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6325), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Program",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6327), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6419), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6423), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6427), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6430), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6432), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6435), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6438), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6440), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6442), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6445), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6448), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6450), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6453), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6455), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6457), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6460), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6462), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6466), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6468), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6470), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6263), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6265), new DateTime(2023, 11, 12, 21, 28, 47, 265, DateTimeKind.Local).AddTicks(6266) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(557), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(559), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(561), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "FieldOfStudy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(572), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "FieldOfStudy",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(574), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "FieldOfStudy",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(575), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "FieldOfStudy",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(577), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "FieldOfStudy",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(578), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Program",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(590), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Program",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(593), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Program",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(594), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "Program",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(596), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "Program",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(597), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(681), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(686), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(689), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(691), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(693), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(696), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(703), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(705), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(708), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(711), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(713), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(715), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(718), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(723), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(725), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(727), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(730), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(733), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(735), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(738), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(518), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(530), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "UserType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(532), new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(533) });
        }
    }
}
