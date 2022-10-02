using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SS.Alteration.Persistence.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlterationStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlterationStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlterationForms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SuitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    AlterationStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlterationForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlterationForms_AlterationStatuses_AlterationStatusId",
                        column: x => x.AlterationStatusId,
                        principalTable: "AlterationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlterationFormId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructions_AlterationForms_AlterationFormId",
                        column: x => x.AlterationFormId,
                        principalTable: "AlterationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AlterationStatuses",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[] { new Guid("205abac2-5b91-4781-aa70-97394bc16abc"), new DateTime(2022, 10, 1, 23, 12, 43, 432, DateTimeKind.Utc).AddTicks(3490), "InProgress" });

            migrationBuilder.InsertData(
                table: "AlterationStatuses",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[] { new Guid("46bc6a0d-fd67-423a-9f65-190a1dbe5e1d"), new DateTime(2022, 10, 1, 23, 12, 43, 432, DateTimeKind.Utc).AddTicks(3492), "Ready" });

            migrationBuilder.InsertData(
                table: "AlterationStatuses",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[] { new Guid("b22464c6-baea-4f03-9678-12db237d4279"), new DateTime(2022, 10, 1, 23, 12, 43, 432, DateTimeKind.Utc).AddTicks(3468), "Received" });

            migrationBuilder.CreateIndex(
                name: "IX_AlterationForms_AlterationStatusId",
                table: "AlterationForms",
                column: "AlterationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructions_AlterationFormId",
                table: "Instructions",
                column: "AlterationFormId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.DropTable(
                name: "AlterationForms");

            migrationBuilder.DropTable(
                name: "AlterationStatuses");
        }
    }
}
