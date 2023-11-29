using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proje_Revize_.Migrations
{
    public partial class guncelleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personel_Birims_BirimId",
                table: "Personel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personel",
                table: "Personel");

            migrationBuilder.RenameTable(
                name: "Personel",
                newName: "Personels");

            migrationBuilder.RenameColumn(
                name: "BirimId",
                table: "Personels",
                newName: "BirimID");

            migrationBuilder.RenameIndex(
                name: "IX_Personel_BirimId",
                table: "Personels",
                newName: "IX_Personels_BirimID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personels",
                table: "Personels",
                column: "PersonelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Birims_BirimID",
                table: "Personels",
                column: "BirimID",
                principalTable: "Birims",
                principalColumn: "BirimID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Birims_BirimID",
                table: "Personels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personels",
                table: "Personels");

            migrationBuilder.RenameTable(
                name: "Personels",
                newName: "Personel");

            migrationBuilder.RenameColumn(
                name: "BirimID",
                table: "Personel",
                newName: "BirimId");

            migrationBuilder.RenameIndex(
                name: "IX_Personels_BirimID",
                table: "Personel",
                newName: "IX_Personel_BirimId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personel",
                table: "Personel",
                column: "PersonelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Personel_Birims_BirimId",
                table: "Personel",
                column: "BirimId",
                principalTable: "Birims",
                principalColumn: "BirimID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
