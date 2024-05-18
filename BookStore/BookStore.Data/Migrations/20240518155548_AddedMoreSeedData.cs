using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Data.Migrations
{
    public partial class AddedMoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "/images/authors/Andrzej_Sapkowski.jpg");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Joanne Rowling CH OBE FRSL, known by her pen name J. K. Rowling, is a British author and philanthropist. She wrote Harry Potter, a seven-volume fantasy series published from 1997 to 2007.", "J.K Rowling" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Description", "ImagePath", "Name" },
                values: new object[,]
                {
                    { 7, "John Ronald Reuel Tolkien CBE FRSL was an English writer and philologist. He was the author of the high fantasy works The Hobbit and The Lord of the Rings. From 1925 to 1945, Tolkien was the Rawlinson and Bosworth Professor of Anglo-Saxon and a Fellow of Pembroke College, both at the University of Oxford.", "/images/authors/tolkien.jpg", "J.R.R Tolkien" },
                    { 8, "Tatsuki Fujimoto is a Japanese manga artist, known for his works Fire Punch and Chainsaw Man.", "/images/authors/Tatsuki Fujimoto.jpg", "Tatsuki Fujimoto" },
                    { 9, "Sui Ishida is a Japanese manga artist. He is popularly known for his dark fantasy manga series Tokyo Ghoul and Choujin X.", "/images/authors/sui ishida.jpg", "Sui Ishida" },
                    { 10, "Asato Asato is a female Japanese novelist. The pen name Asato Asato is a combination of her real name and eighty-eight. .", "/images/authors/Asato_Asato.jpg", "Asato Asato" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Harry has been burdened with a dark, dangerous and seemingly impossible task: that of locating and destroying Voldemort's remaining Horcruxes. Never has Harry felt so alone, or faced a future so full of shadows. But Harry must somehow find within himself the strength to complete the task he has been given. He must leave the warmth, safety and companionship of The Burrow and follow without fear or hesitation the inexorable path laid out for him...In this final, seventh installment of the Harry Potter series, J.K. Rowling unveils in spectacular fashion the answers to the many questions that have been so eagerly awaited.");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[] { 16, "Action" });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "George Allen & Unwin" },
                    { 8, "VIZ Media" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "Discount", "ImagePath", "IsActive", "PageCount", "Price", "PublisherId", "SoldCopies", "Title", "YearOfRelease" },
                values: new object[,]
                {
                    { 13, "In a hole in the ground there lived a hobbit. Not a nasty, dirty, wet hole, filled with the ends of worms and an oozy smell, nor yet a dry, bare, sandy hole with nothing in it to sit down on or to eat: it was a hobbit-hole, and that means comfort.\r\nWritten for J.R.R. Tolkien’s own children, The Hobbit met with instant critical acclaim when it was first published in 1937. Now recognized as a timeless classic, this introduction to the hobbit Bilbo Baggins, the wizard Gandalf, Gollum, and the spectacular world of Middle-earth recounts of the adventures of a reluctant hero, a powerful and dangerous ring, and the cruel dragon Smaug the Magnificent. The text in this 372-page paperback edition is based on that first published in Great Britain by Collins Modern Classics (1998), and includes a note on the text by Douglas A. Anderson (2001).", 0, "/images/books/the hobbit.jpg", true, 366, 25.0, 7, 0, "The Hobbit", 1937 },
                    { 14, "One Ring to rule them all, One Ring to find them, One Ring to bring them all and in the darkness bind them.\r\n\r\nIn ancient times the Rings of Power were crafted by the Elven-smiths, and Sauron, the Dark Lord, forged the One Ring, filling it with his own power so that he could rule all others. But the One Ring was taken from him, and though he sought it throughout Middle-earth, it remained lost to him. After many ages it fell into the hands of Bilbo Baggins, as told in The Hobbit.\r\n\r\nIn a sleepy village in the Shire, young Frodo Baggins finds himself faced with an immense task, as his elderly cousin Bilbo entrusts the Ring to his care. Frodo must leave his home and make a perilous journey across Middle-earth to the Cracks of Doom, there to destroy the Ring and foil the Dark Lord in his evil purpose.", 0, "/images/books/The Fellowship of the Ring.jpg", true, 432, 25.0, 7, 0, "The Fellowship of the Ring", 1954 },
                    { 15, "Begin your journey into Middle-earth.\r\n\r\nThe inspiration for the upcoming original series on Prime Video, The Lord of the Rings: The Rings of Power.\r\n\r\nThe Two Towers is the second part of J.R.R. Tolkien’s epic adventure The Lord of the Rings.\r\n\r\nOne Ring to rule them all, One Ring to find them, One Ring to bring them all and in the darkness bind them.\r\n\r\nFrodo and his Companions of the Ring have been beset by danger during their quest to prevent the Ruling Ring from falling into the hands of the Dark Lord by destroying it in the Cracks of Doom. They have lost the wizard, Gandalf, in a battle in the Mines of Moria. And Boromir, seduced by the power of the Ring, tried to seize it by force. While Frodo and Sam made their escape, the rest of the company was attacked by Orcs. Now they continue the journey alone down the great River Anduin—alone, that is, save for the mysterious creeping figure that follows wherever they go.", 0, "/images/books/the two towers.jpg", true, 432, 25.0, 7, 0, "The Two Towers", 1954 },
                    { 16, "Begin your journey into Middle-earth.\r\n\r\nThe inspiration for the upcoming original series on Prime Video, The Lord of the Rings: The Rings of Power.\r\n\r\nThe Return of the King is the third part of J.R.R. Tolkien’s epic adventure The Lord of the Rings.\r\n\r\nOne Ring to rule them all, One Ring to find them, One Ring to bring them all and in the darkness bind them.\r\n\r\nThe Dark Lord has risen, and as he unleashes hordes of Orcs to conquer all Middle-earth, Frodo and Sam struggle deep into his realm in Mordor.\r\n\r\nTo defeat Sauron, the One Ring must be destroyed in the fires of Mount Doom. But the way is impossibly hard, and Frodo is weakening. The Ring corrupts all who bear it and Frodo’s time is running out.\r\n\r\nWill Sam and Frodo succeed, or will the Dark Lord rule Middle-earth once more?", 0, "/images/books/the return of the king.jpg", true, 432, 25.0, 7, 0, "The Return of the King", 1955 },
                    { 17, "Denji has a simple dream—to live a happy and peaceful life, spending time with a girl he likes. This is a far cry from reality, however, as Denji is forced by the yakuza into killing devils in order to pay off his crushing debts. Using his pet devil Pochita as a weapon, he is ready to do anything for a bit of cash.\r\n\r\nUnfortunately, he has outlived his usefulness and is murdered by a devil in contract with the yakuza. However, in an unexpected turn of events, Pochita merges with Denji's dead body and grants him the powers of a chainsaw devil. Now able to transform parts of his body into chainsaws, a revived Denji uses his new abilities to quickly and brutally dispatch his enemies. Catching the eye of the official devil hunters who arrive at the scene, he is offered work at the Public Safety Bureau as one of them. Now with the means to face even the toughest of enemies, Denji will stop at nothing to achieve his simple teenage dreams.", 0, "/images/books/chainsawman-collection.jpg", true, 2109, 75.0, 8, 0, "Chainsaw Man Box Set", 2023 },
                    { 18, "Suffering from a terminal illness, Yuuta's mother asks him to film her last moments, which he does. From her radiant smile when she is with her family to the times when sickness ravages her body in the hospital, he records hours upon hours of footage. After her passing, Yuuta compiles her life into a movie to screen at his school, deciding to add a bit of fantasy to the ending of his film, Dead Explosion Mother, with a literal explosion!\r\n\r\nFollowing the backlash caused by his supposedly tone-deaf portrayal of his mother's death, Yuuta trudges to the hospital roof to take his own life—but there, he meets a girl named Eri. Captivated by his film, Eri requests Yuuta to make a new one that will blow the previous out of the water and prove his critics wrong. The movie they set out to make will stand apart by blurring the line between fact and fiction. And of course, it wouldn't be a Yuuta film if it didn't have his personal flavor—just a dash of fantasy.", 0, "/images/books/goodbye eri.jpg", true, 208, 26.989999999999998, 8, 0, "Goodbye Eri", 2022 },
                    { 19, "Ghouls live among us, the same as normal people in every way-except for their craving for human flesh.\r\n\r\nA box set that includes all fourteen volumes of the original Tokyo Ghoul series. Includes an exclusive double-sided poster.\r\n\r\nKen Kaneki is an ordinary college student until a violent encounter turns him into the first half-human, half-Ghoul hybrid. Trapped between two worlds, he must survive Ghoul turf wars, learn more about Ghoul society and master his new powers.", 0, "/images/books/tokyo ghoul box set.jpg", true, 2904, 115.0, 8, 0, "Tokyo Ghoul Box Set", 2018 },
                    { 20, "Nine years ago, the Empire of Giad declared war on all neighboring countries using an army of autonomous drones known as the Legion. Threatened by the soulless killing machines, the Republic of San Magnolia, home to the silver-haired Alba race, evacuated its citizens inside 85 districts and developed supposedly unmanned drones known as Juggernauts to counter the Legion. Even after years of war, the Republic boasts that they have suffered zero casualties. However, the battlefield bathed in crimson recites a different melody...\r\n\r\nThe hand dealt to the Colorata people—a minority forced into living in the \"nonexistent\" 86th district—is one of utter contempt and scorn. Looked upon as human filth, they are ordered to pilot the Juggernauts as Processors under the command of Republican Handlers.\r\n\r\nVladilena Milizé, a republican soldier with a strong sense of justice, detests the way her countrymen treat the 86. When she is assigned to the Spearhead Squadron as their handler, she meets a group of oddballs and eventually grows attached to them—particularly their captain, Shinei Nouzen, a boy with a pure sense of purpose and resolve. However, the path they walk is one riddled with death, and growing close to an 86 may have just set Vladilena down a path of despair..", 0, "/images/books/86 vol 1.jpg", true, 309, 16.989999999999998, 8, 0, "86 Vol. 1", 2017 }
                });

            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "AuthorsId", "BooksId" },
                values: new object[,]
                {
                    { 7, 13 },
                    { 7, 14 },
                    { 7, 15 },
                    { 7, 16 },
                    { 8, 17 },
                    { 8, 18 },
                    { 9, 19 },
                    { 10, 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorsId", "BooksId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorsId", "BooksId" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorsId", "BooksId" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorsId", "BooksId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorsId", "BooksId" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorsId", "BooksId" },
                keyValues: new object[] { 8, 18 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorsId", "BooksId" },
                keyValues: new object[] { 9, 19 });

            migrationBuilder.DeleteData(
                table: "AuthorBook",
                keyColumns: new[] { "AuthorsId", "BooksId" },
                keyValues: new object[] { 10, 20 });

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 5000);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "/images/authors/Andrzej_Sapkowski.png");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Ernest Christy Cline is an American science fiction novelist, slam poet, and screenwriter. He wrote the novels Ready Player One, Armada, and Ready Player Two and co-wrote the screenplay for the film adaptation of Ready Player One, directed by Steven Spielberg.", "JK Rowling" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Harry has been burdened with a dark, dangerous and seemingly impossible task: that of locating and destroying Voldemort's remaining Horcruxes. Never has Harry felt so alone, or faced a future so full of shadows. But Harry must somehow find within himself the strength to complete the task he has been given. He must leave the warmth, safety and companionship of The Burrow and follow without fear or hesitation the inexorable path laid out for him...\r\n\r\nIn this final, seventh installment of the Harry Potter series, J.K. Rowling unveils in spectacular fashion the answers to the many questions that have been so eagerly awaited.");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[] { 15, "Light-Novel" });
        }
    }
}
