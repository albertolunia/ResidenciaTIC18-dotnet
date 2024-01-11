using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechMed_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AlterRelationExame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exames_Atendimentos_AtendimentoId",
                table: "Exames");

            migrationBuilder.DropIndex(
                name: "IX_Exames_AtendimentoId",
                table: "Exames");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Exames",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AtendimentoExame",
                columns: table => new
                {
                    AtendimentosId = table.Column<int>(type: "int", nullable: false),
                    ExamesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtendimentoExame", x => new { x.AtendimentosId, x.ExamesId });
                    table.ForeignKey(
                        name: "FK_AtendimentoExame_Atendimentos_AtendimentosId",
                        column: x => x.AtendimentosId,
                        principalTable: "Atendimentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtendimentoExame_Exames_ExamesId",
                        column: x => x.ExamesId,
                        principalTable: "Exames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AtendimentoExame_ExamesId",
                table: "AtendimentoExame",
                column: "ExamesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtendimentoExame");

            migrationBuilder.UpdateData(
                table: "Exames",
                keyColumn: "Descricao",
                keyValue: null,
                column: "Descricao",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Exames",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Exames_AtendimentoId",
                table: "Exames",
                column: "AtendimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exames_Atendimentos_AtendimentoId",
                table: "Exames",
                column: "AtendimentoId",
                principalTable: "Atendimentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
