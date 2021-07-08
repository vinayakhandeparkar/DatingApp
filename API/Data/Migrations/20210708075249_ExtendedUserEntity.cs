using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class ExtendedUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordSalt",
                table: "UsersW",
                type: "BLOB",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordHash",
                table: "UsersW",
                type: "BLOB",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "UsersW",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "UsersW",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "UsersW",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "UsersW",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "UsersW",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interests",
                table: "UsersW",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Introduction",
                table: "UsersW",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KnownAs",
                table: "UsersW",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastActive",
                table: "UsersW",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LookingFor",
                table: "UsersW",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    IsMain = table.Column<bool>(type: "INTEGER", nullable: false),
                    PublicId = table.Column<string>(type: "TEXT", nullable: true),
                    AppUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_UsersW_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "UsersW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_AppUserId",
                table: "Photo",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropColumn(
                name: "City",
                table: "UsersW");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "UsersW");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "UsersW");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "UsersW");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "UsersW");

            migrationBuilder.DropColumn(
                name: "Interests",
                table: "UsersW");

            migrationBuilder.DropColumn(
                name: "Introduction",
                table: "UsersW");

            migrationBuilder.DropColumn(
                name: "KnownAs",
                table: "UsersW");

            migrationBuilder.DropColumn(
                name: "LastActive",
                table: "UsersW");

            migrationBuilder.DropColumn(
                name: "LookingFor",
                table: "UsersW");

            migrationBuilder.AlterColumn<int>(
                name: "PasswordSalt",
                table: "UsersW",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(byte[]),
                oldType: "BLOB",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PasswordHash",
                table: "UsersW",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(byte[]),
                oldType: "BLOB",
                oldNullable: true);
        }
    }
}
