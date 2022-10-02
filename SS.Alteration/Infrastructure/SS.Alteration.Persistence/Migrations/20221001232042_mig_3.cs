using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SS.Alteration.Persistence.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlterationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("419a5cfd-73e6-4830-9a3d-beeec6a23fe0"));

            migrationBuilder.DeleteData(
                table: "AlterationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("8b33f452-fb57-4d1b-97d9-472bc11fc8cb"));

            migrationBuilder.DeleteData(
                table: "AlterationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("db493fba-2f22-4948-b000-9989d4f31846"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AlterationStatuses",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AlterationForms",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AlterationStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AlterationForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AlterationStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("419a5cfd-73e6-4830-9a3d-beeec6a23fe0"), new DateTime(2022, 10, 1, 23, 19, 33, 561, DateTimeKind.Utc).AddTicks(8823), "InProgress", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AlterationStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("8b33f452-fb57-4d1b-97d9-472bc11fc8cb"), new DateTime(2022, 10, 1, 23, 19, 33, 561, DateTimeKind.Utc).AddTicks(8723), "Received", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AlterationStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new Guid("db493fba-2f22-4948-b000-9989d4f31846"), new DateTime(2022, 10, 1, 23, 19, 33, 561, DateTimeKind.Utc).AddTicks(8825), "Ready", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
