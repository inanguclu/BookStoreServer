using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreServer.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_bookCategories",
                table: "bookCategories");

            migrationBuilder.DropIndex(
                name: "IX_bookCategories_BookId",
                table: "bookCategories");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "bookCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bookCategories",
                table: "bookCategories",
                columns: new[] { "BookId", "CategoryId" });

            migrationBuilder.CreateIndex(
                name: "IX_bookCategories_CategoryId",
                table: "bookCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_bookCategories_Categories_CategoryId",
                table: "bookCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookCategories_Categories_CategoryId",
                table: "bookCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bookCategories",
                table: "bookCategories");

            migrationBuilder.DropIndex(
                name: "IX_bookCategories_CategoryId",
                table: "bookCategories");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "bookCategories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bookCategories",
                table: "bookCategories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_bookCategories_BookId",
                table: "bookCategories",
                column: "BookId");
        }
    }
}
