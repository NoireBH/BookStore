using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Data.Migrations
{
    public partial class AddAuthorSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Stephen Edwin King is an American author. Called the \"King of Horror\", he has also explored other genres, among them suspense, crime, science-fiction, fantasy and mystery. He has also written approximately 200 short stories, most of which have been published in collections.", "Stephen King" },
                    { 2, "Andrzej Sapkowski is a Polish fantasy writer, essayist, translator and a trained economist. He is best known for his six-volume series of books The Witcher, which revolves around the eponymous \"witcher,\" a monster-hunter, Geralt of Rivia.", "Andrzej Sapkowski" },
                    { 3, "Jay Asher is an American writer and novelist. He is best known for writing the bestselling 2007 book Thirteen Reasons Why.", "Jay Asher" },
                    { 4, "Christie Golden is an American author. She has written many novels and several short stories in fantasy, horror and science fiction.", "Christie Golden" },
                    { 5, "Ernest Christy Cline is an American science fiction novelist, slam poet, and screenwriter. He wrote the novels Ready Player One, Armada, and Ready Player Two and co-wrote the screenplay for the film adaptation of Ready Player One, directed by Steven Spielberg.", "Ernest Cline" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
