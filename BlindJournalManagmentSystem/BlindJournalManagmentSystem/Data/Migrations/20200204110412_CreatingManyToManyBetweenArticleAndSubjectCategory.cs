using Microsoft.EntityFrameworkCore.Migrations;

namespace BlindJournalManagmentSystem.Data.Migrations
{
    public partial class CreatingManyToManyBetweenArticleAndSubjectCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "articleSubjectCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectCategoryId = table.Column<int>(nullable: false),
                    ArticleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articleSubjectCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_articleSubjectCategories_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_articleSubjectCategories_subjectCategories_SubjectCategoryId",
                        column: x => x.SubjectCategoryId,
                        principalTable: "subjectCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_articleSubjectCategories_ArticleId",
                table: "articleSubjectCategories",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_articleSubjectCategories_SubjectCategoryId",
                table: "articleSubjectCategories",
                column: "SubjectCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "articleSubjectCategories");
        }
    }
}
