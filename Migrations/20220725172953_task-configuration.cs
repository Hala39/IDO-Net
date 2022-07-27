using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class taskconfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9007988c-cd03-434e-8d65-12f9bf7eb601", "AQAAAAEAACcQAAAAEBYv17Yw9LRJALhOseX3QjpAuNKgKZB7/LTxedOtLwQgDihsJ4TWkL2f1WRqDDhEsw==", "f0e7e8f3-30ff-4796-9442-c6e58cff6172" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2022, 7, 25, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8429), new DateTime(2022, 7, 28, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2022, 7, 25, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8446), new DateTime(2022, 8, 7, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2022, 7, 25, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8453), new DateTime(2022, 7, 27, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2022, 7, 25, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8460), new DateTime(2022, 8, 10, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -3,
                column: "Date",
                value: new DateTime(2022, 7, 25, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2022, 7, 25, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8472), new DateTime(2022, 8, 2, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -1,
                column: "Date",
                value: new DateTime(2022, 7, 25, 20, 29, 53, 386, DateTimeKind.Local).AddTicks(8477));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6f9758c-32d0-4ba6-bb61-89b9822930f2", "AQAAAAEAACcQAAAAEAXJJ8ktNx1ciitbAtaYeijAVmibT/8nms2qtXUHzQeRbcu7qFosj2MpFglVigvUHQ==", "7e239acb-620f-4694-8366-da68ccf39c31" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2022, 7, 25, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2402), new DateTime(2022, 7, 28, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2022, 7, 25, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2415), new DateTime(2022, 8, 7, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2022, 7, 25, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2422), new DateTime(2022, 7, 27, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2022, 7, 25, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2427), new DateTime(2022, 8, 10, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -3,
                column: "Date",
                value: new DateTime(2022, 7, 25, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2022, 7, 25, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2439), new DateTime(2022, 8, 2, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: -1,
                column: "Date",
                value: new DateTime(2022, 7, 25, 20, 8, 22, 296, DateTimeKind.Local).AddTicks(2444));
        }
    }
}
