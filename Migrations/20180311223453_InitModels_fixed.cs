using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MDS.Migrations
{
    public partial class InitModels_fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryOrganizations",
                table: "CategoryOrganizations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryOrganizations",
                table: "CategoryOrganizations",
                columns: new[] { "Organization_Id", "Category_Id" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOrganizations_Category_Id",
                table: "CategoryOrganizations",
                column: "Category_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryOrganizations",
                table: "CategoryOrganizations");

            migrationBuilder.DropIndex(
                name: "IX_CategoryOrganizations_Category_Id",
                table: "CategoryOrganizations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryOrganizations",
                table: "CategoryOrganizations",
                columns: new[] { "Category_Id", "Organization_Id" });
        }
    }
}
