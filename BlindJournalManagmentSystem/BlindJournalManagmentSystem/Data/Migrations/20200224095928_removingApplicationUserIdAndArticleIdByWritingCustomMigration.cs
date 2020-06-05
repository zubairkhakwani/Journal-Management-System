using Microsoft.EntityFrameworkCore.Migrations;

namespace BlindJournalManagmentSystem.Data.Migrations
{
    public partial class removingApplicationUserIdAndArticleIdByWritingCustomMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articleReviews_AspNetUsers_ApplicationUserId",
                table: "articleReviews");

            migrationBuilder.DropIndex(
                name: "IX_articleReviews_ApplicationUserId",
                table: "articleReviews");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "articleReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_articleReviews_Articles_ArticleId",
                table: "articleReviews");

            migrationBuilder.DropIndex(
                name: "IX_articleReviews_ArticleId",
                table: "articleReviews");

            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "articleReviews");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
