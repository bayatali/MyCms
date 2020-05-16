using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCms.DataLayer.Migrations
{
    public partial class initialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PageGroups",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupTitle = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageGroups", x => x.GroupID);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    PageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupID = table.Column<int>(nullable: false),
                    PageTitle = table.Column<string>(maxLength: 400, nullable: false),
                    ShortDescription = table.Column<string>(maxLength: 500, nullable: false),
                    PageText = table.Column<string>(nullable: false),
                    PageVisit = table.Column<int>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    PageTags = table.Column<string>(nullable: true),
                    ShowInSlider = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    PageGroupGroupID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.PageID);
                    table.ForeignKey(
                        name: "FK_Pages_PageGroups_PageGroupGroupID",
                        column: x => x.PageGroupGroupID,
                        principalTable: "PageGroups",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pages_PageGroupGroupID",
                table: "Pages",
                column: "PageGroupGroupID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "PageGroups");
        }
    }
}
