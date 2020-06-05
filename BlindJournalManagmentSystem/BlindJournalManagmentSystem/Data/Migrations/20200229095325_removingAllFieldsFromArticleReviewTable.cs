using Microsoft.EntityFrameworkCore.Migrations;

namespace BlindJournalManagmentSystem.Data.Migrations
{
    public partial class removingAllFieldsFromArticleReviewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articleReviews_invitations_InvitationId",
                table: "articleReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_articleReviews_questions_QuestionId",
                table: "articleReviews");

            migrationBuilder.DropIndex(
                name: "IX_articleReviews_InvitationId",
                table: "articleReviews");

            migrationBuilder.DropIndex(
                name: "IX_articleReviews_QuestionId",
                table: "articleReviews");

            migrationBuilder.DropColumn(
                name: "Answer",
                table: "articleReviews");

            migrationBuilder.DropColumn(
                name: "InvitationId",
                table: "articleReviews");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "articleReviews");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "articleReviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvitationId",
                table: "articleReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "articleReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_articleReviews_InvitationId",
                table: "articleReviews",
                column: "InvitationId");

            migrationBuilder.CreateIndex(
                name: "IX_articleReviews_QuestionId",
                table: "articleReviews",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_articleReviews_invitations_InvitationId",
                table: "articleReviews",
                column: "InvitationId",
                principalTable: "invitations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_articleReviews_questions_QuestionId",
                table: "articleReviews",
                column: "QuestionId",
                principalTable: "questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
