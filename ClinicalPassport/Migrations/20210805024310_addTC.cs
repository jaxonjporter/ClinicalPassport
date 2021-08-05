using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicalPassport.Migrations
{
    public partial class addTC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 1,
                column: "InitialDate",
                value: new DateTime(2021, 8, 4, 20, 43, 9, 148, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 2,
                column: "InitialDate",
                value: new DateTime(2021, 8, 4, 20, 43, 9, 152, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 3,
                column: "InitialDate",
                value: new DateTime(2021, 8, 4, 20, 43, 9, 152, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 4,
                column: "InitialDate",
                value: new DateTime(2021, 8, 4, 20, 43, 9, 152, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 5,
                column: "InitialDate",
                value: new DateTime(2021, 8, 4, 20, 43, 9, 152, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 6,
                column: "InitialDate",
                value: new DateTime(2021, 8, 4, 20, 43, 9, 152, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 7,
                columns: new[] { "InitialDate", "TaskId" },
                values: new object[] { new DateTime(2021, 8, 4, 20, 43, 9, 152, DateTimeKind.Local).AddTicks(9533), 7 });

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 8,
                column: "InitialDate",
                value: new DateTime(2021, 8, 4, 20, 43, 9, 152, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.InsertData(
                table: "TaskCompletions",
                columns: new[] { "TaskCompletionId", "FacultyUserId", "InitialDate", "PreceptorInitial", "PreceptorUserId", "StudentCompleted", "StudentUserId", "TaskId", "TaskRating" },
                values: new object[,]
                {
                    { 9, 1111117, new DateTime(2021, 8, 4, 20, 43, 9, 152, DateTimeKind.Local).AddTicks(9544), "", 1111112, false, 1111115, 6, 3 },
                    { 10, 1111117, new DateTime(2021, 8, 4, 20, 43, 9, 152, DateTimeKind.Local).AddTicks(9549), "", 1111112, false, 1111115, 8, 3 },
                    { 11, 1111117, new DateTime(2021, 8, 4, 20, 43, 9, 152, DateTimeKind.Local).AddTicks(9554), "", 1111112, false, 1111115, 10, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 11);

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

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 7,
                columns: new[] { "InitialDate", "TaskId" },
                values: new object[] { new DateTime(2021, 8, 3, 20, 27, 42, 307, DateTimeKind.Local).AddTicks(7372), 4 });

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 8,
                column: "InitialDate",
                value: new DateTime(2021, 8, 3, 20, 27, 42, 307, DateTimeKind.Local).AddTicks(7381));
        }
    }
}
