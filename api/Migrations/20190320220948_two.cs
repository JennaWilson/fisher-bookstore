﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Fisher.Bookstore.Api.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookID",
                table: "Books",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "Books",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Publisher",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Books",
                newName: "BookID");
        }
    }
}
