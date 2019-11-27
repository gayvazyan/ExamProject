﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace TestExample.Migrations
{
    public partial class removeColumeForColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ForColor",
                table: "DbAnswer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ForColor",
                table: "DbAnswer",
                nullable: false,
                defaultValue: 0);
        }
    }
}