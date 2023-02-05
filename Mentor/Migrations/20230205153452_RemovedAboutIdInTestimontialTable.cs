using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mentor.Migrations
{
    public partial class RemovedAboutIdInTestimontialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Testimonials_Abouts_AboutId",
                table: "Testimonials");

            migrationBuilder.AlterColumn<int>(
                name: "AboutId",
                table: "Testimonials",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonials_Abouts_AboutId",
                table: "Testimonials",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Testimonials_Abouts_AboutId",
                table: "Testimonials");

            migrationBuilder.AlterColumn<int>(
                name: "AboutId",
                table: "Testimonials",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonials_Abouts_AboutId",
                table: "Testimonials",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
