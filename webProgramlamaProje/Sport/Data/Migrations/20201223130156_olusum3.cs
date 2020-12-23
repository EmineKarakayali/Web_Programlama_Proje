using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sport.Data.Migrations
{
    public partial class olusum3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportId = table.Column<int>(nullable: false),
                    SportName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportId);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    MemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RealName = table.Column<string>(maxLength: 20, nullable: false),
                    NickName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Tel = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.MemberID);
                    table.ForeignKey(
                        name: "FK_Member_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Community",
                columns: table => new
                {
                    ComId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComName = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    SportsSportId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Community", x => x.ComId);
                    table.ForeignKey(
                        name: "FK_Community_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Community_Sports_SportsSportId",
                        column: x => x.SportsSportId,
                        principalTable: "Sports",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    MeetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    ActTime = table.Column<DateTime>(nullable: false),
                    SportsSportId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.MeetId);
                    table.ForeignKey(
                        name: "FK_Meeting_Sports_SportsSportId",
                        column: x => x.SportsSportId,
                        principalTable: "Sports",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentTxt = table.Column<string>(nullable: true),
                    MemberID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comment_Member_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemSport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberID = table.Column<int>(nullable: false),
                    SportId = table.Column<int>(nullable: false),
                    SportsSportId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemSport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemSport_Member_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemSport_Sports_SportsSportId",
                        column: x => x.SportsSportId,
                        principalTable: "Sports",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemComty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    CommunityComId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemComty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemComty_Community_CommunityComId",
                        column: x => x.CommunityComId,
                        principalTable: "Community",
                        principalColumn: "ComId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemComty_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemMeet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    MeetingMeetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemMeet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemMeet_Meeting_MeetingMeetId",
                        column: x => x.MeetingMeetId,
                        principalTable: "Meeting",
                        principalColumn: "MeetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemMeet_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FotoUrl = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    PostDate = table.Column<DateTime>(nullable: false),
                    CommentId = table.Column<int>(nullable: true),
                    SportId = table.Column<int>(nullable: true),
                    MemberID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Comment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Post_Member_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Post_Sports_SportId",
                        column: x => x.SportId,
                        principalTable: "Sports",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MemberID",
                table: "Comment",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Community_CityId",
                table: "Community",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Community_SportsSportId",
                table: "Community",
                column: "SportsSportId");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_SportsSportId",
                table: "Meeting",
                column: "SportsSportId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_CityId",
                table: "Member",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_MemComty_CommunityComId",
                table: "MemComty",
                column: "CommunityComId");

            migrationBuilder.CreateIndex(
                name: "IX_MemComty_MemberId",
                table: "MemComty",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemMeet_MeetingMeetId",
                table: "MemMeet",
                column: "MeetingMeetId");

            migrationBuilder.CreateIndex(
                name: "IX_MemMeet_MemberId",
                table: "MemMeet",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemSport_MemberID",
                table: "MemSport",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_MemSport_SportsSportId",
                table: "MemSport",
                column: "SportsSportId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_CommentId",
                table: "Post",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_MemberID",
                table: "Post",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_SportId",
                table: "Post",
                column: "SportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemComty");

            migrationBuilder.DropTable(
                name: "MemMeet");

            migrationBuilder.DropTable(
                name: "MemSport");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Community");

            migrationBuilder.DropTable(
                name: "Meeting");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Sports");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
