using Microsoft.EntityFrameworkCore.Migrations;

using System;

namespace Data.Migrations
{
    public partial class SeedDemoData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5", 0, "8e33e23d-0af2-4831-ace3-f13e1d6482ad", "Student", "test5@example.com", true, false, null, null, "test5@example.com", "AQAAAAEAACcQAAAAEJvGLXDb0cxDT37Hab86uLPkPcS6HOqCdmrm4dXZ32ZCJk1xHQJwk1EA0Vmmweng3A==", null, false, "af7dddb4-03c2-45ff-b5b6-44e8a0773f4c", false, "test5@example.com" },
                    { "1", 0, "9115fc36-3f95-456b-b6bb-861bbf5e0846", "Student", "test1@example.com", true, false, null, null, "test1@example.com", "AQAAAAEAACcQAAAAEGLUd/3W/lZw0YuQEy5uoORLKsQulc03nFpk3vncCEJrr0sWnWoSXES6XrGtJzv1mA==", null, false, "aa2d54a4-d2a8-4176-9030-38ed62b1cffb", false, "test1@example.com" },
                    { "4", 0, "4e59e8b8-5dc5-4f40-b3b3-ae035050551a", "Student", "test4@example.com", true, false, null, null, "test4@example.com", "AQAAAAEAACcQAAAAEJQEBVrZ2wo+FnL7cnS9+FVcWg42MdPwjgPLvVR4tbOFJH+GWHsHKhSm++x1/9nA1w==", null, false, "949811fe-9a76-482f-b8e5-28ac08a8143c", false, "test4@example.com" },
                    { "3", 0, "7abd9095-0273-4c05-8cd8-94102d6a109f", "Student", "test3@example.com", true, false, null, null, "test3@example.com", "AQAAAAEAACcQAAAAELyyELOk379Aopk1oHzEfpBNuLxKIMsvIiiPVdLhBTKr/CS6jCQvaXi+zcfVkZh2iQ==", null, false, "4beb3a68-f91c-4bdd-b165-2fe208fe4201", false, "test3@example.com" },
                    { "2", 0, "c51026f8-3c38-4f14-98c4-ce3ec654d92c", "Student", "test2@example.com", true, false, null, null, "test2@example.com", "AQAAAAEAACcQAAAAEJbXu3fI9byGaRcX9oKsIxmRSeBlbbEOUi51PfnG55bWdJjVAO6QpXez3BDGfTKvng==", null, false, "4665666a-9e3a-4a84-ae62-0600ac98d284", false, "test2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Ends", "Name", "Start" },
                values: new object[,]
                {
                    { 30, "Cours_030", new DateTime(2022, 1, 31, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_030", new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, "Cours_031", new DateTime(2022, 2, 1, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_031", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, "Cours_032", new DateTime(2022, 2, 2, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_032", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, "Cours_033", new DateTime(2022, 2, 3, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_033", new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "Cours_034", new DateTime(2022, 2, 4, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_034", new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, "Cours_035", new DateTime(2022, 2, 5, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_035", new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, "Cours_036", new DateTime(2022, 2, 6, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_036", new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, "Cours_037", new DateTime(2022, 2, 7, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_037", new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, "Cours_038", new DateTime(2022, 2, 8, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_038", new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, "Cours_039", new DateTime(2022, 2, 9, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_039", new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, "Cours_040", new DateTime(2022, 2, 10, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_040", new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, "Cours_042", new DateTime(2022, 2, 12, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_042", new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, "Cours_043", new DateTime(2022, 2, 13, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_043", new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, "Cours_044", new DateTime(2022, 2, 14, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_044", new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, "Cours_045", new DateTime(2022, 2, 15, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_045", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, "Cours_046", new DateTime(2022, 2, 16, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_046", new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, "Cours_047", new DateTime(2022, 2, 17, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_047", new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, "Cours_048", new DateTime(2022, 2, 18, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_048", new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, "Cours_049", new DateTime(2022, 2, 19, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_049", new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, "Cours_050", new DateTime(2022, 2, 20, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_050", new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, "Cours_029", new DateTime(2022, 1, 30, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_029", new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, "Cours_041", new DateTime(2022, 2, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_041", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "Cours_028", new DateTime(2022, 1, 29, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_028", new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, "Cours_026", new DateTime(2022, 1, 27, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_026", new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Cours_002", new DateTime(2022, 1, 3, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_002", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Cours_003", new DateTime(2022, 1, 4, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_003", new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Cours_004", new DateTime(2022, 1, 5, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_004", new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Cours_005", new DateTime(2022, 1, 6, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_005", new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Cours_006", new DateTime(2022, 1, 7, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_006", new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Cours_007", new DateTime(2022, 1, 8, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_007", new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Cours_008", new DateTime(2022, 1, 9, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_008", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Cours_009", new DateTime(2022, 1, 10, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_009", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Cours_010", new DateTime(2022, 1, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_010", new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Cours_011", new DateTime(2022, 1, 12, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_011", new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Cours_012", new DateTime(2022, 1, 13, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_012", new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "Cours_027", new DateTime(2022, 1, 28, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_027", new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Cours_013", new DateTime(2022, 1, 14, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_013", new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Ends", "Name", "Start" },
                values: new object[,]
                {
                    { 15, "Cours_015", new DateTime(2022, 1, 16, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_015", new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Cours_016", new DateTime(2022, 1, 17, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_016", new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Cours_017", new DateTime(2022, 1, 18, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_017", new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Cours_018", new DateTime(2022, 1, 19, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_018", new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Cours_019", new DateTime(2022, 1, 20, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_019", new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "Cours_020", new DateTime(2022, 1, 21, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_020", new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Cours_021", new DateTime(2022, 1, 22, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_021", new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "Cours_022", new DateTime(2022, 1, 23, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_022", new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "Cours_023", new DateTime(2022, 1, 24, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_023", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "Cours_024", new DateTime(2022, 1, 25, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_024", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "Cours_025", new DateTime(2022, 1, 26, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_025", new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Cours_014", new DateTime(2022, 1, 15, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_014", new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, "Cours_001", new DateTime(2022, 1, 2, 2, 0, 0, 0, DateTimeKind.Unspecified), "Cours_001", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "StudentCourse",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, "1" },
                    { 2, "1" },
                    { 3, "1" },
                    { 4, "2" },
                    { 5, "2" },
                    { 6, "2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, "1" });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, "1" });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, "1" });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, "2" });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5, "2" });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 6, "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
