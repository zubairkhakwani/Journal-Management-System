using Microsoft.EntityFrameworkCore.Migrations;

namespace BlindJournalManagmentSystem.Data.Migrations
{
    public partial class addingReadByAssociateEditorAndReadByAuthorFIeldsInInvitationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "readByAssociateEditor",
                table: "invitations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "readByAuthor",
                table: "invitations",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "readByAssociateEditor",
                table: "invitations");

            migrationBuilder.DropColumn(
                name: "readByAuthor",
                table: "invitations");
        }
    }
}
