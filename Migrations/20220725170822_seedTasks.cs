using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class seedTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "Tasks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6f9758c-32d0-4ba6-bb61-89b9822930f2", "AQAAAAEAACcQAAAAEAXJJ8ktNx1ciitbAtaYeijAVmibT/8nms2qtXUHzQeRbcu7qFosj2MpFglVigvUHQ==", "7e239acb-620f-4694-8366-da68ccf39c31" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Category", "Date", "DueDate", "Importance", "Status", "Title", "UserId", "estimatedTime", "estimationUnit" },
                values: new object[,]
                {
                    { -7, "Education", new DateTime(2022, 7, 25, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2402), new DateTime(2022, 7, 28, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2252), 2, 0, "Prepare the essay", "b74ddd14-6340-4840-95c2-db12554843e5", 6, 1 },
                    { -6, "Maintenance", new DateTime(2022, 7, 25, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2415), new DateTime(2022, 8, 7, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2299), 0, 0, "Format the PC", "b74ddd14-6340-4840-95c2-db12554843e5", 3, 1 },
                    { -5, "Maintenance", new DateTime(2022, 7, 25, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2422), new DateTime(2022, 7, 27, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2304), 1, 0, "Contact the support team of XYZ software to ask about the guarantee pricing", "b74ddd14-6340-4840-95c2-db12554843e5", 30, 0 },
                    { -4, "Work", new DateTime(2022, 7, 25, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2427), new DateTime(2022, 8, 10, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2308), 0, 0, "Translate the resume", "b74ddd14-6340-4840-95c2-db12554843e5", 2, 1 },
                    { -3, "Maintenance", new DateTime(2022, 7, 25, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2433), null, 1, 0, "Fix the power button of the TV", "b74ddd14-6340-4840-95c2-db12554843e5", 1, 1 },
                    { -2, "Work", new DateTime(2022, 7, 25, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2439), new DateTime(2022, 8, 2, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2317), 2, 0, "Prepare the XD design", "b74ddd14-6340-4840-95c2-db12554843e5", 8, 2 },
                    { -1, "Education", new DateTime(2022, 7, 25, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2444), null, 0, 0, "Email the faculity director about the progress", "b74ddd14-6340-4840-95c2-db12554843e5", 15, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a63ecf05-b04e-44d8-9162-265f69a1a537", "AQAAAAEAACcQAAAAEOszE8wwiu/u98xSt9W7Vttknb3Y45C7tZdw2OyJ2GIanafyAm8yqt4SCpA0J20f1A==", "f192a8a5-266a-4693-a781-4f1e9fa2fa51" });
        }
    }
}
