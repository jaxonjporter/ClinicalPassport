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
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskId);
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
                    TaskCompletionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    StudentUserId = table.Column<int>(type: "int", nullable: false),
                    FacultyUserId = table.Column<int>(type: "int", nullable: false),
                    PreceptorUserId = table.Column<int>(type: "int", nullable: false),
                    PreceptorInitial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InitialDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskCompletions", x => x.TaskCompletionId);
                    table.ForeignKey(
                        name: "FK_TaskCompletions_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "TaskId",
                        onDelete: ReferentialAction.Cascade);
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
                columns: new[] { "UserId", "Address", "Email", "FirstName", "LastName", "Phone", "Role" },
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
                columns: new[] { "TaskId", "CategoryID", "Description", "Required" },
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
                columns: new[] { "TaskCompletionId", "FacultyUserId", "InitialDate", "PreceptorInitial", "PreceptorUserId", "StudentUserId", "TaskId", "TaskRating" },
                values: new object[,]
                {
                    { 2, 1111117, new DateTime(2021, 7, 26, 20, 19, 23, 41, DateTimeKind.Local).AddTicks(7812), "JP", 1111112, 1111115, 2, 5 },
                    { 3, 1111117, new DateTime(2021, 7, 26, 20, 19, 23, 41, DateTimeKind.Local).AddTicks(7844), "JP", 1111112, 1111115, 4, 4 },
                    { 1, 1111117, new DateTime(2021, 7, 26, 20, 19, 23, 39, DateTimeKind.Local).AddTicks(8999), "JP", 1111112, 1111115, 1, 4 },
                    { 5, 1111117, new DateTime(2021, 7, 26, 20, 19, 23, 41, DateTimeKind.Local).AddTicks(7852), "JP", 1111112, 1111114, 1, 5 },
                    { 4, 1111117, new DateTime(2021, 7, 26, 20, 19, 23, 41, DateTimeKind.Local).AddTicks(7849), "JP", 1111112, 1111115, 5, 2 },
                    { 6, 1111117, new DateTime(2021, 7, 26, 20, 19, 23, 41, DateTimeKind.Local).AddTicks(7855), "JP", 1111112, 1111115, 9, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskCompletions_TaskId",
                table: "TaskCompletions",
                column: "TaskId");

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
                name: "Users");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
