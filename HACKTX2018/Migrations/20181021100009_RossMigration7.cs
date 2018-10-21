using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HACKTX2018.Migrations
{
    public partial class RossMigration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Companies_ComapnyCompanyID",
                table: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.RenameColumn(
                name: "ComapnyCompanyID",
                table: "OrderDetails",
                newName: "OrganizationID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ComapnyCompanyID",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrganizationID");

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganizationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    NumberShares = table.Column<string>(nullable: false),
                    CompanyValue = table.Column<string>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationID);
                    table.ForeignKey(
                        name: "FK_Organizations_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_UserID",
                table: "Organizations",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Organizations_OrganizationID",
                table: "OrderDetails",
                column: "OrganizationID",
                principalTable: "Organizations",
                principalColumn: "OrganizationID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Organizations_OrganizationID",
                table: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.RenameColumn(
                name: "OrganizationID",
                table: "OrderDetails",
                newName: "ComapnyCompanyID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrganizationID",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ComapnyCompanyID");

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyValue = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    NumberShares = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_Companies_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_UserID",
                table: "Companies",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Companies_ComapnyCompanyID",
                table: "OrderDetails",
                column: "ComapnyCompanyID",
                principalTable: "Companies",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
