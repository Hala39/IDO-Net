using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class enums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Category = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    estimationUnit = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    estimatedTime = table.Column<short>(type: "SMALLINT", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Date = table.Column<string>(type: "nvarchar(48)", nullable: false, defaultValue: "2022-07-28 21:52:22.404156"),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Importance = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "LOW"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b74ddd14-6340-4840-95c2-db12554843e5", 0, "f76149c6-6a34-4263-bd27-4a78700b257a", "user@ido.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEBp66PojsfapmI2o30/JRQ1YrKSmab6ZWcS2PF2foTM7XWhwP1O2YIpnmCxLDra6Hw==", null, false, "dd8e92d1-67f4-4cfe-bd91-d4e290b0c5c5", false, "IDO User" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Category", "Date", "DueDate", "Importance", "Status", "Title", "UserId", "estimatedTime", "estimationUnit" },
                values: new object[] { -7, "Education", "2022-07-28 21:52:22.4039056", new DateTime(2022, 7, 31, 21, 52, 22, 403, DateTimeKind.Local).AddTicks(8905), "HIGH", 1, "Prepare the essay", "b74ddd14-6340-4840-95c2-db12554843e5", (short)6, "hours" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Category", "Date", "DueDate", "Status", "Title", "UserId", "estimatedTime", "estimationUnit" },
                values: new object[] { -6, "Maintenance", "2022-07-28 21:52:22.4039069", new DateTime(2022, 8, 10, 21, 52, 22, 403, DateTimeKind.Local).AddTicks(8956), 2, "Format the PC", "b74ddd14-6340-4840-95c2-db12554843e5", (short)3, "hours" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Category", "Date", "DueDate", "Importance", "Status", "Title", "UserId", "estimatedTime", "estimationUnit" },
                values: new object[] { -5, "Maintenance", "2022-07-28 21:52:22.4039075", new DateTime(2022, 7, 30, 21, 52, 22, 403, DateTimeKind.Local).AddTicks(8962), "MEDIUM", 1, "Contact the support team of XYZ software to ask about the guarantee pricing", "b74ddd14-6340-4840-95c2-db12554843e5", (short)30, "minutes" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Category", "Date", "DueDate", "Status", "Title", "UserId", "estimatedTime", "estimationUnit" },
                values: new object[] { -4, "Work", "2022-07-28 21:52:22.4039081", new DateTime(2022, 8, 13, 21, 52, 22, 403, DateTimeKind.Local).AddTicks(8966), 1, "Translate the resume", "b74ddd14-6340-4840-95c2-db12554843e5", (short)2, "hours" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Category", "Date", "DueDate", "Importance", "Title", "UserId", "estimatedTime", "estimationUnit" },
                values: new object[] { -3, "Maintenance", "2022-07-28 21:52:22.4039086", null, "MEDIUM", "Fix the power button of the TV", "b74ddd14-6340-4840-95c2-db12554843e5", (short)1, "hour" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Category", "Date", "DueDate", "Importance", "Status", "Title", "UserId", "estimatedTime", "estimationUnit" },
                values: new object[] { -2, "Work", "2022-07-28 21:52:22.4039092", new DateTime(2022, 8, 5, 21, 52, 22, 403, DateTimeKind.Local).AddTicks(8974), "HIGH", 2, "Prepare the XD design", "b74ddd14-6340-4840-95c2-db12554843e5", (short)8, "days" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Category", "Date", "DueDate", "Title", "UserId", "estimatedTime", "estimationUnit" },
                values: new object[] { -1, "Education", "2022-07-28 21:52:22.4039099", null, "Email the faculity director about the progress", "b74ddd14-6340-4840-95c2-db12554843e5", (short)15, "minutes" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
