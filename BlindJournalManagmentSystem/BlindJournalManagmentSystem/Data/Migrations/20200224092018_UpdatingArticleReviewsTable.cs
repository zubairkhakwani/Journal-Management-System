using Microsoft.EntityFrameworkCore.Migrations;

namespace BlindJournalManagmentSystem.Data.Migrations
{
    public partial class UpdatingArticleReviewsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "articleReviews",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "articleReviews",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_articleReviews_QuestionId",
                table: "articleReviews",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_articleReviews_questions_QuestionId",
                table: "articleReviews",
                column: "QuestionId",
                principalTable: "questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articleReviews_questions_QuestionId",
                table: "articleReviews");

            migrationBuilder.DropIndex(
                name: "IX_articleReviews_QuestionId",
                table: "articleReviews");

            migrationBuilder.DropColumn(
                name: "Answer",
                table: "articleReviews");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "articleReviews");
        }
    }
}
