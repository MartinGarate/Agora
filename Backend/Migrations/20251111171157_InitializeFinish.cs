using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class InitializeFinish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "Capacitaciones");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInscripcion",
                table: "Inscripciones",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaHora",
                value: new DateTime(2025, 11, 21, 14, 11, 57, 368, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaHora",
                value: new DateTime(2025, 12, 1, 14, 11, 57, 368, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaHora",
                value: new DateTime(2025, 12, 1, 14, 11, 57, 368, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 11, 14, 11, 57, 368, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 11, 14, 11, 57, 368, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 11, 14, 11, 57, 368, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 11, 14, 11, 57, 368, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 11, 14, 11, 57, 368, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 11, 14, 11, 57, 368, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 11, 14, 11, 57, 368, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 11, 14, 11, 57, 368, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 11, 14, 11, 57, 368, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 11, 14, 11, 57, 368, DateTimeKind.Local).AddTicks(1237));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaInscripcion",
                table: "Inscripciones");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "Capacitaciones",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeleteTime", "FechaHora" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 26, 14, 52, 50, 152, DateTimeKind.Local).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeleteTime", "FechaHora" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 5, 14, 52, 50, 152, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeleteTime", "FechaHora" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 5, 14, 52, 50, 152, DateTimeKind.Local).AddTicks(1511) });
        }
    }
}
