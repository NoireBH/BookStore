using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Data.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_YearOfRelease",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_YearOfRelease",
                table: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PublisherId",
                table: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_Books_YearOfRelease",
                table: "Books",
                column: "YearOfRelease");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_YearOfRelease",
                table: "Books",
                column: "YearOfRelease",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
