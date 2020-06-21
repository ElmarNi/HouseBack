using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseBack.Migrations
{
    public partial class Fixe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WhatWeDoHomePages",
                table: "WhatWeDoHomePages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeBanners",
                table: "HomeBanners");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "WhatWeDoHomePages");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "WhatWeDoHomePages");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "HomeBanners");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "HomeBanners");

            migrationBuilder.RenameTable(
                name: "WhatWeDoHomePages",
                newName: "WhatWeDoHomePage");

            migrationBuilder.RenameTable(
                name: "HomeBanners",
                newName: "HomeBanner");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "HomeBanner",
                newName: "ImageUrl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WhatWeDoHomePage",
                table: "WhatWeDoHomePage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeBanner",
                table: "HomeBanner",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WhatWeDoHomePage",
                table: "WhatWeDoHomePage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeBanner",
                table: "HomeBanner");

            migrationBuilder.RenameTable(
                name: "WhatWeDoHomePage",
                newName: "WhatWeDoHomePages");

            migrationBuilder.RenameTable(
                name: "HomeBanner",
                newName: "HomeBanners");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "HomeBanners",
                newName: "Image");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "WhatWeDoHomePages",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "WhatWeDoHomePages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "HomeBanners",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "HomeBanners",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WhatWeDoHomePages",
                table: "WhatWeDoHomePages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeBanners",
                table: "HomeBanners",
                column: "Id");
        }
    }
}
