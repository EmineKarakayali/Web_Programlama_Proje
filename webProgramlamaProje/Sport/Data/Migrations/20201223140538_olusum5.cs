using Microsoft.EntityFrameworkCore.Migrations;

namespace Sport.Data.Migrations
{
    public partial class olusum5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NickName",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "RealName",
                table: "Member");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Member",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Member",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Member",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Capasity",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "City",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Member_CountryId",
                table: "Member",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_CityId",
                table: "Meeting",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_CountryId",
                table: "Meeting",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_City_CityId",
                table: "Meeting",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Country_CountryId",
                table: "Meeting",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Country_CountryId",
                table: "Member",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_City_CityId",
                table: "Meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Country_CountryId",
                table: "Meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Country_CountryId",
                table: "Member");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Member_CountryId",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_CityId",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_CountryId",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_City_CountryId",
                table: "City");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "Capasity",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "City");

            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "Member",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RealName",
                table: "Member",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
