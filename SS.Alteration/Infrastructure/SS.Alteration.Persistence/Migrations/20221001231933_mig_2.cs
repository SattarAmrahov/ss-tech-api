using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SS.Alteration.Persistence.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlterationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("205abac2-5b91-4781-aa70-97394bc16abc"));

            migrationBuilder.DeleteData(
                table: "AlterationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("46bc6a0d-fd67-423a-9f65-190a1dbe5e1d"));

            migrationBuilder.DeleteData(
                table: "AlterationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("b22464c6-baea-4f03-9678-12db237d4279"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "AlterationStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "AlterationForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Instructions");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "AlterationStatuses");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "AlterationForms");

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
        }
    }
}
