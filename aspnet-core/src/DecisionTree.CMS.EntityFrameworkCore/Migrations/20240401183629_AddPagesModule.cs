using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DecisionTree.CMS.Migrations
{
    /// <inheritdoc />
    public partial class AddPagesModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Pages");

            migrationBuilder.CreateTable(
                name: "PGS_Page",
                schema: "Pages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsHomePage = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PGS_Page", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PGS_Page_CreationTime",
                schema: "Pages",
                table: "PGS_Page",
                column: "CreationTime");

            migrationBuilder.CreateIndex(
                name: "IX_PGS_Page_Slug",
                schema: "Pages",
                table: "PGS_Page",
                column: "Slug");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PGS_Page",
                schema: "Pages");
        }
    }
}
