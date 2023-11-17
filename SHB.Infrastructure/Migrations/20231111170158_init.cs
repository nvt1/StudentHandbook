using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SHB.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserTypeDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FieldOfStudy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacultyId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldOfStudy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FieldOfStudy_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    FieldOfStudyId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Program_FieldOfStudy_FieldOfStudyId",
                        column: x => x.FieldOfStudyId,
                        principalTable: "FieldOfStudy",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PracticalHours = table.Column<int>(type: "int", nullable: true),
                    TheoreticalHours = table.Column<int>(type: "int", nullable: true),
                    Semester = table.Column<int>(type: "int", nullable: true),
                    ProgramId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Program_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Program",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacultyId = table.Column<int>(type: "int", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProgramId = table.Column<int>(type: "int", nullable: true),
                    UserTypeId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldOfStudyId = table.Column<int>(type: "int", nullable: true),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_FieldOfStudy_FieldOfStudyId",
                        column: x => x.FieldOfStudyId,
                        principalTable: "FieldOfStudy",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_Program_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Program",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_UserType_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserType",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Faculty",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(557), "Admin", "Description for Computer Science faculty", "Faculty of Computer Science", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(557), "Admin" },
                    { 2, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(559), "Admin", "Description for Electrical Engineering faculty", "Faculty of Electrical Engineering", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(560), "Admin" },
                    { 3, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(561), "Admin", "Description for Mechanical Engineering faculty", "Faculty of Mechanical Engineering", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(561), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Status", "UpdatedAt", "UpdatedBy", "UserTypeCode", "UserTypeDesc" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(518), "Admin", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(527), "Admin", "Admin", "Administrator" },
                    { 2, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(530), "Admin", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(531), "Admin", "Teacher", "Teacher" },
                    { 3, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(532), "Admin", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(533), "Admin", "Student", "Student" }
                });

            migrationBuilder.InsertData(
                table: "FieldOfStudy",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "FacultyId", "Name", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(572), "Admin", 1, "Computer Science", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(572), "Admin" },
                    { 2, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(574), "Admin", 2, "Electrical Engineering", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(574), "Admin" },
                    { 3, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(575), "Admin", 3, "Mechanical Engineering", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(576), "Admin" },
                    { 4, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(577), "Admin", 1, "Physics", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(577), "Admin" },
                    { 5, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(578), "Admin", 2, "Mathematics", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(578), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Program",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "FieldOfStudyId", "Name", "Status", "UpdatedAt", "UpdatedBy", "Year" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(590), "Admin", 1, "Computer Science Program", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(591), "Admin", 4 },
                    { 2, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(593), "Admin", 2, "Electrical Engineering Program", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(593), "Admin", 4 },
                    { 3, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(594), "Admin", 3, "Mechanical Engineering Program", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(595), "Admin", 4 },
                    { 4, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(596), "Admin", 4, "Physics Program", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(596), "Admin", 3 },
                    { 5, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(597), "Admin", 5, "Mathematics Program", 1, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(598), "Admin", 3 }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseCode", "CreatedAt", "CreatedBy", "Name", "PracticalHours", "ProgramId", "Semester", "Status", "TheoreticalHours", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "C001", null, null, "Introduction to Programming", 30, 1, 1, null, 60, null, null },
                    { 2, "C002", null, null, "Data Structures and Algorithms", 35, 1, 1, null, 55, null, null },
                    { 3, "C003", null, null, "Database Management", 25, 2, 1, null, 45, null, null },
                    { 4, "C004", null, null, "Web Development", 40, 2, 1, null, 50, null, null },
                    { 5, "C005", null, null, "Operating Systems", 30, 3, 1, null, 60, null, null },
                    { 6, "C006", null, null, "Computer Networks", 35, 3, 1, null, 55, null, null },
                    { 7, "C007", null, null, "Software Engineering", 30, 4, 1, null, 60, null, null },
                    { 8, "C008", null, null, "Machine Learning", 40, 4, 1, null, 50, null, null },
                    { 9, "C009", null, null, "Mobile App Development", 35, 5, 1, null, 55, null, null },
                    { 10, "C010", null, null, "Artificial Intelligence", 40, 5, 1, null, 50, null, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "AvatarUrl", "BirthDay", "City", "Country", "CreatedAt", "CreatedBy", "Email", "FacultyId", "FieldOfStudyId", "FirstName", "FullName", "LastName", "MiddleName", "Password", "Phone", "PostalCode", "ProgramId", "Status", "StudentCode", "UpdatedAt", "UpdatedBy", "UserTypeId" },
                values: new object[,]
                {
                    { 1, "123 Main Street", null, new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anytown", "USA", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(681), "Admin", "john.doe@example.com", 1, 1, "John", "John Doe Smith", "Smith", "Doe", "12345", "123-456-7890", "12345", 1, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(682), "Admin", 1 },
                    { 2, "456 Elm Street", null, new DateTime(1985, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Othercity", "Canada", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(686), "Admin", "alice.eve@example.com", 2, 2, "Alice", "Alice Eve Johnson", "Johnson", "Eve", "12345", "456-789-0123", "54321", 2, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(686), "Admin", 2 },
                    { 3, "789 Oak Street", null, new DateTime(1988, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anothercity", "UK", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(689), "Admin", "michael.james@example.com", 3, 3, "Michael", "Michael James Brown", "Brown", "James", "12345", "789-012-3456", "98765", 3, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(689), "Admin", 3 },
                    { 4, "101 Oak Lane", null, new DateTime(1991, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sometown", "USA", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(691), "Admin", "sarah.jane@example.com", 3, 4, "Sarah", "Sarah Jane Wilson", "Wilson", "Jane", "12345", "555-123-4567", "54321", 4, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(691), "Admin", 1 },
                    { 5, "567 Elm Road", null, new DateTime(1987, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anytown", "USA", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(693), "Admin", "robert.david@example.com", 2, 5, "Robert", "Robert David Jones", "Jones", "David", "12345", "567-234-5678", "12345", 5, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(694), "Admin", 2 },
                    { 6, "222 Maple Street", null, new DateTime(1992, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Othercity", "Canada", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(696), "Admin", "emily.grace@example.com", 1, 1, "Emily", "Emily Grace Martinez", "Martinez", "Grace", "12345", "222-345-6789", "98765", 1, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(696), "Admin", 3 },
                    { 7, "444 Cedar Lane", null, new DateTime(1986, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sometown", "USA", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(703), "Admin", "william.joseph@example.com", 2, 2, "William", "William Joseph Lee", "Lee", "Joseph", "12345", "444-456-7890", "12345", 2, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(704), "Admin", 1 },
                    { 8, "777 Pine Road", null, new DateTime(1993, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Othercity", "Canada", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(705), "Admin", "olivia.sophia@example.com", 3, 3, "Olivia", "Olivia Sophia Garcia", "Garcia", "Sophia", "12345", "777-567-1234", "54321", 3, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(706), "Admin", 2 },
                    { 9, "555 Birch Lane", null, new DateTime(1989, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sometown", "USA", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(708), "Admin", "james.andrew@example.com", 1, 4, "James", "James Andrew Davis", "Davis", "Andrew", "12345", "555-123-6789", "98765", 4, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(708), "Admin", 3 },
                    { 10, "333 Cedar Road", null, new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sometown", "USA", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(711), "Admin", "sophia.grace@example.com", 2, 5, "Sophia", "Sophia Grace Hernandez", "Hernandez", "Grace", "12345", "333-234-5678", "12345", 5, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(711), "Admin", 1 },
                    { 11, "777 Pine Lane", null, new DateTime(1995, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Othercity", "Canada", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(713), "Admin", "logan.david@example.com", 1, 1, "Logan", "Logan David Lopez", "Lopez", "David", "12345", "777-567-6789", "54321", 1, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(714), "Admin", 2 },
                    { 12, "444 Maple Lane", null, new DateTime(1996, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anothercity", "UK", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(715), "Admin", "ava.emily@example.com", 2, 2, "Ava", "Ava Emily Thompson", "Thompson", "Emily", "12345", "444-234-5678", "98765", 2, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(716), "Admin", 3 },
                    { 13, "123 Main Road", null, new DateTime(1990, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anytown", "USA", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(718), "Admin", "noah.william@example.com", 3, 3, "Noah", "Noah William Wilson", "Wilson", "William", "12345", "123-345-6789", "12345", 3, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(718), "Admin", 1 },
                    { 14, "456 Elm Lane", null, new DateTime(1991, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Othercity", "Canada", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(723), "Admin", "mia.olivia@example.com", 3, 4, "Mia", "Mia Olivia Garcia", "Garcia", "Olivia", "12345", "456-567-8901", "54321", 4, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(723), "Admin", 2 },
                    { 15, "555 Oak Road", null, new DateTime(1989, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sometown", "USA", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(725), "Admin", "liam.joseph@example.com", 2, 5, "Liam", "Liam Joseph Martinez", "Martinez", "Joseph", "12345", "555-234-8901", "98765", 5, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(725), "Admin", 3 },
                    { 16, "666 Pine Lane", null, new DateTime(1987, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anothercity", "UK", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(727), "Admin", "isabella.sophia@example.com", 1, 1, "Isabella", "Isabella Sophia Lee", "Lee", "Sophia", "12345", "666-345-6789", "98765", 1, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(728), "Admin", 1 },
                    { 17, "123 Main Lane", null, new DateTime(1992, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anytown", "USA", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(730), "Admin", "oliver.james@example.com", 2, 2, "Oliver", "Oliver James Davis", "Davis", "James", "12345", "123-567-8901", "12345", 2, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(730), "Admin", 2 },
                    { 18, "777 Elm Road", null, new DateTime(1993, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Othercity", "Canada", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(733), "Admin", "sophia.elizabeth@example.com", 3, 3, "Sophia", "Sophia Elizabeth Brown", "Brown", "Elizabeth", "12345", "777-234-5678", "54321", 3, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(733), "Admin", 3 },
                    { 19, "555 Oak Lane", null, new DateTime(1988, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sometown", "USA", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(735), "Admin", "liam.michael@example.com", 1, 4, "Liam", "Liam Michael Wilson", "Wilson", "Michael", "12345", "555-567-9012", "98765", 4, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(736), "Admin", 1 },
                    { 20, "666 Maple Road", null, new DateTime(1994, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anothercity", "UK", new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(738), "Admin", "amelia.charlotte@example.com", 2, 5, "Amelia", "Amelia Charlotte Hernandez", "Hernandez", "Charlotte", "12345", "666-234-5678", "98765", 5, 1, null, new DateTime(2023, 11, 12, 0, 1, 58, 325, DateTimeKind.Local).AddTicks(738), "Admin", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_ProgramId",
                table: "Course",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_FieldOfStudy_FacultyId",
                table: "FieldOfStudy",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Program_FieldOfStudyId",
                table: "Program",
                column: "FieldOfStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_User_FacultyId",
                table: "User",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_User_FieldOfStudyId",
                table: "User",
                column: "FieldOfStudyId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ProgramId",
                table: "User",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserTypeId",
                table: "User",
                column: "UserTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Program");

            migrationBuilder.DropTable(
                name: "UserType");

            migrationBuilder.DropTable(
                name: "FieldOfStudy");

            migrationBuilder.DropTable(
                name: "Faculty");
        }
    }
}
