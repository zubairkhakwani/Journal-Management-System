using Microsoft.EntityFrameworkCore.Migrations;

namespace BlindJournalManagmentSystem.Data.Migrations
{
    public partial class removeUserIdAndArticleIdAndAddInvitationIdToArticleReviewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articleReviews_Articles_ArticleId",
                table: "articleReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_articleReviews_AspNetUsers_UserId",
                table: "articleReviews");

            migrationBuilder.DropIndex(
                name: "IX_articleReviews_UserId",
                table: "articleReviews");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "articleReviews");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "articleReviews");

            migrationBuilder.AlterColumn<int>(
                name: "ArticleId",
                table: "articleReviews",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "articleReviews",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvitationId",
                table: "articleReviews",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_articleReviews_ApplicationUserId",
                table: "articleReviews",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_articleReviews_InvitationId",
                table: "articleReviews",
                column: "InvitationId");

            migrationBuilder.AddForeignKey(
                name: "FK_articleReviews_AspNetUsers_ApplicationUserId",
                table: "articleReviews",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_articleReviews_Articles_ArticleId",
                table: "articleReviews",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_articleReviews_invitations_InvitationId",
                table: "articleReviews",
                column: "InvitationId",
                principalTable: "invitations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articleReviews_AspNetUsers_ApplicationUserId",
                table: "articleReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_articleReviews_Articles_ArticleId",
                table: "articleReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_articleReviews_invitations_InvitationId",
                table: "articleReviews");

            migrationBuilder.DropIndex(
                name: "IX_articleReviews_ApplicationUserId",
                table: "articleReviews");

            migrationBuilder.DropIndex(
                name: "IX_articleReviews_InvitationId",
                table: "articleReviews");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "articleReviews");

            migrationBuilder.DropColumn(
                name: "InvitationId",
                table: "articleReviews");

            migrationBuilder.AlterColumn<int>(
                name: "ArticleId",
                table: "articleReviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "articleReviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "articleReviews",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_articleReviews_UserId",
                table: "articleReviews",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_articleReviews_Articles_ArticleId",
                table: "articleReviews",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_articleReviews_AspNetUsers_UserId",
                table: "articleReviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
