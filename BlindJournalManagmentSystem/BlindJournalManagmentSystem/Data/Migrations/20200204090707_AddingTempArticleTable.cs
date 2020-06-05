using Microsoft.EntityFrameworkCore.Migrations;

namespace BlindJournalManagmentSystem.Data.Migrations
{
    public partial class AddingTempArticleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TempArticle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Abstract = table.Column<string>(maxLength: 300, nullable: true),
                    Files = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    FieldsIds = table.Column<string>(nullable: true),
                    SubjectCategoriesIds = table.Column<string>(nullable: true),
                    AuthorsEmails = table.Column<string>(nullable: true),
                    OpposedAuthorsEmails = table.Column<string>(nullable: true),
                    CoverLetter = table.Column<string>(nullable: true),
                    PreviouSubmittedArticleId = table.Column<int>(nullable: true),
                    IsThereFundingToReportForThisSubmission = table.Column<string>(nullable: true),
                    DoesContainSupplementaryMaterial = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempArticle", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TempArticle");
        }
    }
}
