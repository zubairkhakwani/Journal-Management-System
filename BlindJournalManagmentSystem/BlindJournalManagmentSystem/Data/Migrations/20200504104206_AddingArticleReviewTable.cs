using Microsoft.EntityFrameworkCore.Migrations;

namespace BlindJournalManagmentSystem.Data.Migrations
{
    public partial class AddingArticleReviewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "articleReviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    invitationid = table.Column<int>(nullable: false),
                    questionid = table.Column<int>(nullable: false),
                    answer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articleReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_articleReviews_invitations_invitationid",
                        column: x => x.invitationid,
                        principalTable: "invitations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_articleReviews_questions_questionid",
                        column: x => x.questionid,
                        principalTable: "questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_articleReviews_invitationid",
                table: "articleReviews",
                column: "invitationid");

            migrationBuilder.CreateIndex(
                name: "IX_articleReviews_questionid",
                table: "articleReviews",
                column: "questionid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "articleReviews");
        }
    }
}
