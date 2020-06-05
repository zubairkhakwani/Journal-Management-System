using Microsoft.EntityFrameworkCore.Migrations;

namespace BlindJournalManagmentSystem.Data.Migrations
{
    public partial class removingArticleReviewsFromDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "articleReview");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
