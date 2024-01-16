﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tasky.Migrations
{
    public partial class addmember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AspNetUsers_ApplicationUserId",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Tasks",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_ApplicationUserId",
                table: "Tasks",
                newName: "IX_Tasks_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Descriere",
                table: "Tasks",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AspNetUsers_UserId",
                table: "Tasks",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AspNetUsers_UserId",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Tasks",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                newName: "IX_Tasks_ApplicationUserId");

            migrationBuilder.AlterColumn<string>(
                name: "Descriere",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AspNetUsers_ApplicationUserId",
                table: "Tasks",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
