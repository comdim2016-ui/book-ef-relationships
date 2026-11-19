using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassesManyToMany.Migrations
{
    /// <inheritdoc />
    public partial class manualmanytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubject_Students_StudentsId",
                table: "StudentSubject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSubject",
                table: "StudentSubject");

            migrationBuilder.RenameColumn(
                name: "StudentsId",
                table: "StudentSubject",
                newName: "SubjectOd");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "StudentSubject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Enrolled",
                table: "StudentSubject",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "StudentSubject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSubject",
                table: "StudentSubject",
                columns: new[] { "StudentId", "SubjectsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubject_Students_StudentId",
                table: "StudentSubject",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubject_Students_StudentId",
                table: "StudentSubject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSubject",
                table: "StudentSubject");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudentSubject");

            migrationBuilder.DropColumn(
                name: "Enrolled",
                table: "StudentSubject");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "StudentSubject");

            migrationBuilder.RenameColumn(
                name: "SubjectOd",
                table: "StudentSubject",
                newName: "StudentsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSubject",
                table: "StudentSubject",
                columns: new[] { "StudentsId", "SubjectsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubject_Students_StudentsId",
                table: "StudentSubject",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
