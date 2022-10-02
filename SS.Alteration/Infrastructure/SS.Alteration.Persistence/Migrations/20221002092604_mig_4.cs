using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SS.Alteration.Persistence.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlterationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("984344a6-4fcb-4be5-ab53-ab120244ea5f"));

            migrationBuilder.DeleteData(
                table: "AlterationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("aa22709b-77c9-434a-8ac1-128e76cef7b0"));

            migrationBuilder.DeleteData(
                table: "AlterationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ff0120fa-5a63-4b36-8388-e6f89f11e949"));

            migrationBuilder.InsertData(
                table: "AlterationStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("42f20caa-d8c0-4a50-9f8e-d89b81b3ad4f"), new DateTime(2022, 10, 2, 9, 26, 4, 626, DateTimeKind.Utc).AddTicks(2873), "Ready", null });

            migrationBuilder.InsertData(
                table: "AlterationStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("a155c0ae-f226-41e1-8282-d9012558e1ff"), new DateTime(2022, 10, 2, 9, 26, 4, 626, DateTimeKind.Utc).AddTicks(2871), "InProgress", null });

            migrationBuilder.InsertData(
                table: "AlterationStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("fdcb36c8-b345-4984-a25e-616154ec3610"), new DateTime(2022, 10, 2, 9, 26, 4, 626, DateTimeKind.Utc).AddTicks(2846), "Received", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlterationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("42f20caa-d8c0-4a50-9f8e-d89b81b3ad4f"));

            migrationBuilder.DeleteData(
                table: "AlterationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a155c0ae-f226-41e1-8282-d9012558e1ff"));

            migrationBuilder.DeleteData(
                table: "AlterationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("fdcb36c8-b345-4984-a25e-616154ec3610"));

            migrationBuilder.InsertData(
                table: "AlterationStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("984344a6-4fcb-4be5-ab53-ab120244ea5f"), new DateTime(2022, 10, 1, 23, 20, 42, 665, DateTimeKind.Utc).AddTicks(3978), "InProgress", null });

            migrationBuilder.InsertData(
                table: "AlterationStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("aa22709b-77c9-434a-8ac1-128e76cef7b0"), new DateTime(2022, 10, 1, 23, 20, 42, 665, DateTimeKind.Utc).AddTicks(3980), "Ready", null });

            migrationBuilder.InsertData(
                table: "AlterationStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("ff0120fa-5a63-4b36-8388-e6f89f11e949"), new DateTime(2022, 10, 1, 23, 20, 42, 665, DateTimeKind.Utc).AddTicks(3950), "Received", null });
        }
    }
}
