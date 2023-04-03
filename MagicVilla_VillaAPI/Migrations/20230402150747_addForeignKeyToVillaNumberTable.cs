using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addForeignKeyToVillaNumberTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaId",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers",
                column: "VillaId");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers",
                column: "VillaId",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaId",
                table: "VillaNumbers");
        }
    }
}
