using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Weblog.Migrations
{
    /// <inheritdoc />
    public partial class AddedArticleEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Authors_AuthorUserName",
                table: "Article");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Article",
                table: "Article");

            migrationBuilder.RenameTable(
                name: "Article",
                newName: "Articles");

            migrationBuilder.RenameIndex(
                name: "IX_Article_AuthorUserName",
                table: "Articles",
                newName: "IX_Articles_AuthorUserName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articles",
                table: "Articles",
                column: "ArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Authors_AuthorUserName",
                table: "Articles",
                column: "AuthorUserName",
                principalTable: "Authors",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Authors_AuthorUserName",
                table: "Articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articles",
                table: "Articles");

            migrationBuilder.RenameTable(
                name: "Articles",
                newName: "Article");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_AuthorUserName",
                table: "Article",
                newName: "IX_Article_AuthorUserName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Article",
                table: "Article",
                column: "ArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Authors_AuthorUserName",
                table: "Article",
                column: "AuthorUserName",
                principalTable: "Authors",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
