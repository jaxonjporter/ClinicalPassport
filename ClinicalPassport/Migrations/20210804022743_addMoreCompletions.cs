using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicalPassport.Migrations
{
    public partial class addMoreCompletions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 1,
                column: "InitialDate",
                value: new DateTime(2021, 8, 3, 20, 27, 42, 301, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 2,
                column: "InitialDate",
                value: new DateTime(2021, 8, 3, 20, 27, 42, 307, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 3,
                column: "InitialDate",
                value: new DateTime(2021, 8, 3, 20, 27, 42, 307, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 4,
                column: "InitialDate",
                value: new DateTime(2021, 8, 3, 20, 27, 42, 307, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 5,
                column: "InitialDate",
                value: new DateTime(2021, 8, 3, 20, 27, 42, 307, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 6,
                column: "InitialDate",
                value: new DateTime(2021, 8, 3, 20, 27, 42, 307, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.InsertData(
                table: "TaskCompletions",
                columns: new[] { "TaskCompletionId", "FacultyUserId", "InitialDate", "PreceptorInitial", "PreceptorUserId", "StudentCompleted", "StudentUserId", "TaskId", "TaskRating" },
                values: new object[,]
                {
                    { 7, 1111117, new DateTime(2021, 8, 3, 20, 27, 42, 307, DateTimeKind.Local).AddTicks(7372), "", 1111112, false, 1111115, 4, 3 },
                    { 8, 1111117, new DateTime(2021, 8, 3, 20, 27, 42, 307, DateTimeKind.Local).AddTicks(7381), "", 1111112, false, 1111115, 3, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1111115,
                column: "FirstName",
                value: "Michael");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 1,
                column: "InitialDate",
                value: new DateTime(2021, 8, 3, 19, 18, 10, 698, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 2,
                column: "InitialDate",
                value: new DateTime(2021, 8, 3, 19, 18, 10, 702, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 3,
                column: "InitialDate",
                value: new DateTime(2021, 8, 3, 19, 18, 10, 702, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 4,
                column: "InitialDate",
                value: new DateTime(2021, 8, 3, 19, 18, 10, 702, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 5,
                column: "InitialDate",
                value: new DateTime(2021, 8, 3, 19, 18, 10, 702, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 6,
                column: "InitialDate",
                value: new DateTime(2021, 8, 3, 19, 18, 10, 702, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1111115,
                column: "FirstName",
                value: "Micheal");
        }
    }
}
