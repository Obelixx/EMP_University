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
                    { "cde148ba-6cd1-4a42-ae62-fe25421dd77f", 0, "af0f3160-dfda-4797-90ae-ef7dcf1250b2", "Student", "test5@example.com", true, false, null, null, null, "AQAAAAEAACcQAAAAEIMfBa72/qZIJqnSMXb44LKnwouANe6HlqNx5opJToHp5UnJMRXUf0iJVV0Ny2xBzw==", null, false, "577341e0-be25-4a7c-b33b-4731f29bca48", false, "test5@example.com" },
                    { "73b3ca4e-5343-4df8-ac30-fd32aeb1e356", 0, "6ffe4da2-05c9-4fe8-a33e-ea0e70bc1843", "Student", "test1@example.com", true, false, null, null, null, "AQAAAAEAACcQAAAAENpNPvp/47Z/iDb6EPAdxcbvbVmim9gpkrvhbkWin9BWxCnIifnOxnHR7i6EMXNKVg==", null, false, "14895523-aae5-4335-9831-e211cefd1533", false, "test1@example.com" },
                    { "083e1ecf-6d05-47ba-a3c2-da13d03c7e7f", 0, "7e75488e-e23d-4781-96d6-ef36ec92eebc", "Student", "test4@example.com", true, false, null, null, null, "AQAAAAEAACcQAAAAEH0PdSpKTwgYWgQlgsgbYSUNab1lbVFgJ8EoLA0peeCCqRO8Fq1XEfT9bhMmTORZEg==", null, false, "7f4b7542-d036-4f7a-9892-24bb3d85ccb3", false, "test4@example.com" },
                    { "8dae27da-4dbb-4878-9c0e-f52126f53260", 0, "a6256859-1052-4ce2-a77a-460eaefe02eb", "Student", "test3@example.com", true, false, null, null, null, "AQAAAAEAACcQAAAAEAJOgnsCqhV523ZGQG+rTXKIvFU7Yq+pO+a86OR4D3Uyaiu3C75KTvBQplG1PhA5Aw==", null, false, "f11fc2a9-9126-4474-86b4-1db595acd409", false, "test3@example.com" },
                    { "a38dc379-4cc1-414b-b3a2-d97f4defe8c7", 0, "0a31811a-34c9-4e92-b261-b587f4f25a00", "Student", "test2@example.com", true, false, null, null, null, "AQAAAAEAACcQAAAAEA2waOgYmZdfItfjpq+K4YJz0G3nucL6sZEJ1jRQr551cZv578ONJpH7TqZITqfH0w==", null, false, "630cb14e-ba53-4681-885b-06d68fb5433c", false, "test2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Ends", "Name", "Start" },
                values: new object[,]
                {
                    { 30, "Cours_030", new DateTime(2021, 6, 16, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2838), "Cours_030", new DateTime(2021, 6, 16, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2838) },
                    { 31, "Cours_031", new DateTime(2021, 6, 17, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2848), "Cours_031", new DateTime(2021, 6, 17, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2848) },
                    { 32, "Cours_032", new DateTime(2021, 6, 18, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2859), "Cours_032", new DateTime(2021, 6, 18, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2859) },
                    { 33, "Cours_033", new DateTime(2021, 6, 19, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2870), "Cours_033", new DateTime(2021, 6, 19, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2870) },
                    { 34, "Cours_034", new DateTime(2021, 6, 20, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2880), "Cours_034", new DateTime(2021, 6, 20, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2880) },
                    { 35, "Cours_035", new DateTime(2021, 6, 21, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2891), "Cours_035", new DateTime(2021, 6, 21, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2891) },
                    { 36, "Cours_036", new DateTime(2021, 6, 22, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2902), "Cours_036", new DateTime(2021, 6, 22, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2902) },
                    { 37, "Cours_037", new DateTime(2021, 6, 23, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2975), "Cours_037", new DateTime(2021, 6, 23, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2975) },
                    { 38, "Cours_038", new DateTime(2021, 6, 24, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2990), "Cours_038", new DateTime(2021, 6, 24, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2990) },
                    { 39, "Cours_039", new DateTime(2021, 6, 25, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(3001), "Cours_039", new DateTime(2021, 6, 25, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(3001) },
                    { 40, "Cours_040", new DateTime(2021, 6, 26, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(3012), "Cours_040", new DateTime(2021, 6, 26, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(3012) },
                    { 42, "Cours_042", new DateTime(2021, 6, 28, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(3034), "Cours_042", new DateTime(2021, 6, 28, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(3034) },
                    { 43, "Cours_043", new DateTime(2021, 6, 29, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(3045), "Cours_043", new DateTime(2021, 6, 29, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(3045) },
                    { 44, "Cours_044", new DateTime(2021, 6, 30, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(3055), "Cours_044", new DateTime(2021, 6, 30, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(3055) },
                    { 45, "Cours_045", new DateTime(2021, 7, 1, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(3066), "Cours_045", new DateTime(2021, 7, 1, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(3066) },
                    { 46, "Cours_046", new DateTime(2021, 7, 2, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(3077), "Cours_046", new DateTime(2021, 7, 2, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(3077) },
                    { 47, "Cours_047", new DateTime(2021, 7, 3, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(3087), "Cours_047", new DateTime(2021, 7, 3, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(3087) },
                    { 48, "Cours_048", new DateTime(2021, 7, 4, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(3098), "Cours_048", new DateTime(2021, 7, 4, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(3098) },
                    { 49, "Cours_049", new DateTime(2021, 7, 5, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(3109), "Cours_049", new DateTime(2021, 7, 5, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(3109) },
                    { 50, "Cours_050", new DateTime(2021, 7, 6, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(3119), "Cours_050", new DateTime(2021, 7, 6, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(3119) },
                    { 29, "Cours_029", new DateTime(2021, 6, 15, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2827), "Cours_029", new DateTime(2021, 6, 15, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2827) },
                    { 41, "Cours_041", new DateTime(2021, 6, 27, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(3023), "Cours_041", new DateTime(2021, 6, 27, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(3023) },
                    { 28, "Cours_028", new DateTime(2021, 6, 14, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2816), "Cours_028", new DateTime(2021, 6, 14, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2816) },
                    { 26, "Cours_026", new DateTime(2021, 6, 12, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2795), "Cours_026", new DateTime(2021, 6, 12, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2795) },
                    { 2, "Cours_002", new DateTime(2021, 5, 19, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2476), "Cours_002", new DateTime(2021, 5, 19, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2476) },
                    { 3, "Cours_003", new DateTime(2021, 5, 20, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2537), "Cours_003", new DateTime(2021, 5, 20, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2537) },
                    { 4, "Cours_004", new DateTime(2021, 5, 21, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2551), "Cours_004", new DateTime(2021, 5, 21, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2551) },
                    { 5, "Cours_005", new DateTime(2021, 5, 22, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2563), "Cours_005", new DateTime(2021, 5, 22, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2563) },
                    { 6, "Cours_006", new DateTime(2021, 5, 23, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2575), "Cours_006", new DateTime(2021, 5, 23, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2575) },
                    { 7, "Cours_007", new DateTime(2021, 5, 24, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2587), "Cours_007", new DateTime(2021, 5, 24, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2587) },
                    { 8, "Cours_008", new DateTime(2021, 5, 25, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2599), "Cours_008", new DateTime(2021, 5, 25, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2599) },
                    { 9, "Cours_009", new DateTime(2021, 5, 26, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2610), "Cours_009", new DateTime(2021, 5, 26, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2610) },
                    { 10, "Cours_010", new DateTime(2021, 5, 27, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2621), "Cours_010", new DateTime(2021, 5, 27, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2621) },
                    { 11, "Cours_011", new DateTime(2021, 5, 28, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2632), "Cours_011", new DateTime(2021, 5, 28, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2632) },
                    { 12, "Cours_012", new DateTime(2021, 5, 29, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2643), "Cours_012", new DateTime(2021, 5, 29, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2643) },
                    { 27, "Cours_027", new DateTime(2021, 6, 13, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2806), "Cours_027", new DateTime(2021, 6, 13, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2806) },
                    { 13, "Cours_013", new DateTime(2021, 5, 30, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2654), "Cours_013", new DateTime(2021, 5, 30, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2654) }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Ends", "Name", "Start" },
                values: new object[,]
                {
                    { 15, "Cours_015", new DateTime(2021, 6, 1, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2676), "Cours_015", new DateTime(2021, 6, 1, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2676) },
                    { 16, "Cours_016", new DateTime(2021, 6, 2, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2688), "Cours_016", new DateTime(2021, 6, 2, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2688) },
                    { 17, "Cours_017", new DateTime(2021, 6, 3, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2699), "Cours_017", new DateTime(2021, 6, 3, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2699) },
                    { 18, "Cours_018", new DateTime(2021, 6, 4, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2710), "Cours_018", new DateTime(2021, 6, 4, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2710) },
                    { 19, "Cours_019", new DateTime(2021, 6, 5, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2720), "Cours_019", new DateTime(2021, 6, 5, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2720) },
                    { 20, "Cours_020", new DateTime(2021, 6, 6, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2731), "Cours_020", new DateTime(2021, 6, 6, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2731) },
                    { 21, "Cours_021", new DateTime(2021, 6, 7, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2742), "Cours_021", new DateTime(2021, 6, 7, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2742) },
                    { 22, "Cours_022", new DateTime(2021, 6, 8, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2752), "Cours_022", new DateTime(2021, 6, 8, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2752) },
                    { 23, "Cours_023", new DateTime(2021, 6, 9, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2763), "Cours_023", new DateTime(2021, 6, 9, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2763) },
                    { 24, "Cours_024", new DateTime(2021, 6, 10, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2774), "Cours_024", new DateTime(2021, 6, 10, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2774) },
                    { 25, "Cours_025", new DateTime(2021, 6, 11, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2784), "Cours_025", new DateTime(2021, 6, 11, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2784) },
                    { 14, "Cours_014", new DateTime(2021, 5, 31, 17, 32, 14, 556, DateTimeKind.Local).AddTicks(2665), "Cours_014", new DateTime(2021, 5, 31, 15, 32, 14, 556, DateTimeKind.Local).AddTicks(2665) },
                    { 1, "Cours_001", new DateTime(2021, 5, 18, 17, 32, 14, 550, DateTimeKind.Local).AddTicks(1466), "Cours_001", new DateTime(2021, 5, 18, 15, 32, 14, 550, DateTimeKind.Local).AddTicks(1466) }
                });

            migrationBuilder.InsertData(
                table: "StudentCourse",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, "73b3ca4e-5343-4df8-ac30-fd32aeb1e356" },
                    { 2, "73b3ca4e-5343-4df8-ac30-fd32aeb1e356" },
                    { 3, "73b3ca4e-5343-4df8-ac30-fd32aeb1e356" },
                    { 4, "a38dc379-4cc1-414b-b3a2-d97f4defe8c7" },
                    { 5, "a38dc379-4cc1-414b-b3a2-d97f4defe8c7" },
                    { 6, "a38dc379-4cc1-414b-b3a2-d97f4defe8c7" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "083e1ecf-6d05-47ba-a3c2-da13d03c7e7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8dae27da-4dbb-4878-9c0e-f52126f53260");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cde148ba-6cd1-4a42-ae62-fe25421dd77f");

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
                keyValues: new object[] { 1, "73b3ca4e-5343-4df8-ac30-fd32aeb1e356" });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, "73b3ca4e-5343-4df8-ac30-fd32aeb1e356" });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, "73b3ca4e-5343-4df8-ac30-fd32aeb1e356" });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, "a38dc379-4cc1-414b-b3a2-d97f4defe8c7" });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5, "a38dc379-4cc1-414b-b3a2-d97f4defe8c7" });

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 6, "a38dc379-4cc1-414b-b3a2-d97f4defe8c7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73b3ca4e-5343-4df8-ac30-fd32aeb1e356");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a38dc379-4cc1-414b-b3a2-d97f4defe8c7");

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
