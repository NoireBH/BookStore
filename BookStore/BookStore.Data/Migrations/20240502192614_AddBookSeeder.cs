using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Data.Migrations
{
    public partial class AddBookSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "Discount", "IsActive", "PageCount", "PublisherId", "SoldCopies", "Title", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, "The story follows the experiences of seven children as they are terrorized by an evil entity that exploits the fears of its victims to disguise itself", 0, true, 1138, 1, 0, "It", 1986 },
                    { 2, "Geralt the Witcher—revered and hated—holds the line against the monsters plaguing humanity in this collection of adventures, the first chapter in Andrzej Sapkowski’s groundbreaking epic fantasy series that inspired the hit Netflix show and the blockbuster video games.", 0, true, 2000, 2, 0, "The Witcher Saga", 2020 },
                    { 3, "Thirteen Reasons Why is a young adult novel written by Jay Asher in 2007, which follows the story of Hannah Baker, a high school freshman, and the thirteen reasons why she has died by suicide.", 0, true, 320, 3, 0, "13 Reasons Why", 2007 },
                    { 4, "Arthas: Rise of the Lich King is a Warcraft novel by Christie Golden, who is the author of multiple Star Trek and other Warcraft novels. The novel dealing with the progression of Arthas from Prince to the Lich King, was released on April 21, 2009.", 0, true, 416, 4, 0, "World of Warcraft: Arthas: Rise of the Lich King", 2007 },
                    { 5, "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.", 0, true, 384, 5, 0, "Ready Player One", 2011 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);
        }
    }
}
