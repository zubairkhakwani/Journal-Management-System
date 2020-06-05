using Microsoft.EntityFrameworkCore.Migrations;

namespace BlindJournalManagmentSystem.Data.Migrations
{
    public partial class AddingArticleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    CoverLetter = table.Column<string>(maxLength: 100, nullable: false),
                    Abstract = table.Column<string>(maxLength: 300, nullable: false),
                    IsFunded = table.Column<string>(nullable: false),
                    DeosContainSupplementaryMaterial = table.Column<string>(nullable: false),
                    PreviousSubmittedArticleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Articles_PreviousSubmittedArticleId",
                        column: x => x.PreviousSubmittedArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_PreviousSubmittedArticleId",
                table: "Articles",
                column: "PreviousSubmittedArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
