using Microsoft.EntityFrameworkCore.Migrations;

namespace BlindJournalManagmentSystem.Data.Migrations
{
    public partial class CreatingOneToManyBetweenApplicationUserAndInstitution : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstitutionId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_InstitutionId",
                table: "AspNetUsers",
                column: "InstitutionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_institutions_InstitutionId",
                table: "AspNetUsers",
                column: "InstitutionId",
                principalTable: "institutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_institutions_InstitutionId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_InstitutionId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "InstitutionId",
                table: "AspNetUsers");
        }
    }
}
