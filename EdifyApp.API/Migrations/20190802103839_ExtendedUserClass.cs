using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EdifyApp.API.Migrations
{
    public partial class ExtendedUserClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrentOutstandingDuties",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FillInEmployeeReportsTo",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LeaveCommencingDate",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LeaveReason",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfDays",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RemainingLeaveDays",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnDate",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "StatusOfCurrentOutstandingDuties",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TakeoverEmployee",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentOutstandingDuties",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FillInEmployeeReportsTo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LeaveCommencingDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LeaveReason",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NumberOfDays",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RemainingLeaveDays",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StatusOfCurrentOutstandingDuties",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TakeoverEmployee",
                table: "Users");
        }
    }
}
