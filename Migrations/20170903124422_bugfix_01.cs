using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace vega.Migrations
{
    public partial class bugfix_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Models_ModelId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_ModelId",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "MakeId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Contact",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Contact",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contact",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MakeId",
                table: "Vehicles");

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Contact",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Contact",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "Email",
                table: "Contact",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ModelId",
                table: "Vehicles",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Models_ModelId",
                table: "Vehicles",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
