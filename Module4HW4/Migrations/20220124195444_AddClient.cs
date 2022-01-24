using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Module4HW4.Migrations
{
    public partial class AddClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Birthday", "FirstName", "Language", "SecondName" },
                values: new object[,]
                {
                    { 1, new DateTime(2001, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vadim", "UA", "Bilyi" },
                    { 2, new DateTime(2001, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dima", "UA", "Yampolskiy" },
                    { 3, new DateTime(2000, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dima", "UA", "Menshakov" },
                    { 4, new DateTime(2001, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roma", "RU", "Momot" },
                    { 5, new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sergay", "UA", "Naimutenko" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Budget", "ClientId", "Name", "StartedDate" },
                values: new object[,]
                {
                    { 1, 100000m, 1, "Pockemon GO", new DateTime(2017, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 100000m, 2, "Project F", new DateTime(2018, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 20m, 3, "Medical Mathematic Project", new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1000m, 4, "Diya", new DateTime(2016, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1000000m, 5, "Pockemon Unite", new DateTime(2017, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientId",
                table: "Project",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Project_ClientId",
                table: "Project");

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Project");
        }
    }
}
