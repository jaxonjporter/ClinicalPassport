using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicalPassport.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskID);
                    table.ForeignKey(
                        name: "FK_Tasks_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskCompletions",
                columns: table => new
                {
                    TaskCompletionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskID = table.Column<int>(type: "int", nullable: false),
                    StudentUserID = table.Column<int>(type: "int", nullable: false),
                    StudentUserID1 = table.Column<int>(type: "int", nullable: true),
                    FacultyUserID = table.Column<int>(type: "int", nullable: false),
                    FacultyUserID1 = table.Column<int>(type: "int", nullable: true),
                    PreceptorUserID = table.Column<int>(type: "int", nullable: false),
                    PreceptorUserID1 = table.Column<int>(type: "int", nullable: true),
                    PreceptorInitial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InitialDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskCompletions", x => x.TaskCompletionID);
                    table.ForeignKey(
                        name: "FK_TaskCompletions_Tasks_TaskID",
                        column: x => x.TaskID,
                        principalTable: "Tasks",
                        principalColumn: "TaskID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskCompletions_Users_FacultyUserID",
                        column: x => x.FacultyUserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_TaskCompletions_Users_FacultyUserID1",
                        column: x => x.FacultyUserID1,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskCompletions_Users_PreceptorUserID",
                        column: x => x.PreceptorUserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_TaskCompletions_Users_PreceptorUserID1",
                        column: x => x.PreceptorUserID1,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskCompletions_Users_StudentUserID",
                        column: x => x.StudentUserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_TaskCompletions_Users_StudentUserID1",
                        column: x => x.StudentUserID1,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description" },
                values: new object[,]
                {
                    { 2, "Procedural" },
                    { 3, "Screening" },
                    { 4, "Diagnostic" },
                    { 1, "Documentation" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Address", "Email", "FirstName", "LastName", "Phone", "Role" },
                values: new object[,]
                {
                    { 1111111, "123 Anywhere Street", "dw22@gmail.com", "Dwayne 'The Rock'", "Johnson", "4358858888", "admin" },
                    { 1111112, "123 Anywhere Street", "jaxonutah@gmail.com", "Jaxon", "Porter", "4352250000", "preceptor" },
                    { 1111113, "123 Anywhere Street", "fm@gmail.com", "Freddie", "Mercury", "4358858888", "faculty" },
                    { 1111114, "123 Anywhere Street", "dw22@gmail.com", "Henry", "Spencer", "4358858888", "student" },
                    { 1111115, "1 Anywhere Street", "dw22@gmail.com", "Micheal", "Scott", "4358858889", "student" },
                    { 1111116, "432 Anywhere Street", "cb@gmail.com", "Creed", "Bratton", "4358858888", "student" },
                    { 1111117, "123 Pensylvania ave", "pv@gmail.com", "Phyllis", "Vance", "4358858888", "faculty" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskID", "CategoryID", "Description", "Required" },
                values: new object[,]
                {
                    { 2, 2, "Aseptic Technique Before Surgery", true },
                    { 6, 2, "Assist in Surgery", true },
                    { 3, 3, "Bone Density Study - Adult", false },
                    { 7, 3, "Apgar Score - Infant", true },
                    { 4, 4, "ADD/ADHD Diagnosis - Child", true },
                    { 8, 4, "ADD/ADHD Diagnosis - Adolescent", true },
                    { 1, 1, "Discharge Summary", true },
                    { 5, 1, "History and Physical - Adult", true },
                    { 9, 1, "History and Physical - Infant", true },
                    { 10, 1, "History and Physical - Child", true }
                });

            migrationBuilder.InsertData(
                table: "TaskCompletions",
                columns: new[] { "TaskCompletionID", "FacultyUserID", "FacultyUserID1", "InitialDate", "PreceptorInitial", "PreceptorUserID", "PreceptorUserID1", "StudentUserID", "StudentUserID1", "TaskID", "TaskRating" },
                values: new object[,]
                {
                    { 2, 1111117, null, new DateTime(2021, 6, 14, 19, 56, 36, 938, DateTimeKind.Local).AddTicks(2792), "JP", 1111112, null, 1111115, null, 2, 5 },
                    { 3, 1111117, null, new DateTime(2021, 6, 14, 19, 56, 36, 938, DateTimeKind.Local).AddTicks(2840), "JP", 1111112, null, 1111115, null, 4, 4 },
                    { 1, 1111117, null, new DateTime(2021, 6, 14, 19, 56, 36, 935, DateTimeKind.Local).AddTicks(8533), "JP", 1111112, null, 1111115, null, 1, 4 },
                    { 5, 1111117, null, new DateTime(2021, 6, 14, 19, 56, 36, 938, DateTimeKind.Local).AddTicks(2847), "JP", 1111112, null, 1111114, null, 1, 5 },
                    { 4, 1111117, null, new DateTime(2021, 6, 14, 19, 56, 36, 938, DateTimeKind.Local).AddTicks(2844), "JP", 1111112, null, 1111115, null, 5, 2 },
                    { 6, 1111117, null, new DateTime(2021, 6, 14, 19, 56, 36, 938, DateTimeKind.Local).AddTicks(2851), "JP", 1111112, null, 1111115, null, 9, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskCompletions_FacultyUserID",
                table: "TaskCompletions",
                column: "FacultyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskCompletions_FacultyUserID1",
                table: "TaskCompletions",
                column: "FacultyUserID1");

            migrationBuilder.CreateIndex(
                name: "IX_TaskCompletions_PreceptorUserID",
                table: "TaskCompletions",
                column: "PreceptorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskCompletions_PreceptorUserID1",
                table: "TaskCompletions",
                column: "PreceptorUserID1");

            migrationBuilder.CreateIndex(
                name: "IX_TaskCompletions_StudentUserID",
                table: "TaskCompletions",
                column: "StudentUserID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskCompletions_StudentUserID1",
                table: "TaskCompletions",
                column: "StudentUserID1");

            migrationBuilder.CreateIndex(
                name: "IX_TaskCompletions_TaskID",
                table: "TaskCompletions",
                column: "TaskID");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CategoryID",
                table: "Tasks",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskCompletions");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
