using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RuleMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Message = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuleMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VisitPurpose = table.Column<string>(type: "text", nullable: false),
                    Citizenship = table.Column<string>(type: "text", nullable: false),
                    DateOfEntry = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    HasPolicy = table.Column<bool>(type: "boolean", nullable: false),
                    HasInn = table.Column<bool>(type: "boolean", nullable: false),
                    IsLongStay = table.Column<bool>(type: "boolean", nullable: false),
                    HighQualify = table.Column<bool>(type: "boolean", nullable: false),
                    ProgramResetelment = table.Column<bool>(type: "boolean", nullable: false),
                    IsRegistered = table.Column<bool>(type: "boolean", nullable: false),
                    HasFingerprints = table.Column<bool>(type: "boolean", nullable: false),
                    KnowRussian = table.Column<bool>(type: "boolean", nullable: false),
                    HasPatent = table.Column<bool>(type: "boolean", nullable: false),
                    PatentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Mess_ID = table.Column<int>(type: "integer", nullable: true),
                    TimeText = table.Column<string>(type: "text", nullable: false),
                    Days = table.Column<int>(type: "integer", nullable: true),
                    d_type = table.Column<bool>(type: "boolean", nullable: true),
                    patentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rules_RuleMessages_Mess_ID",
                        column: x => x.Mess_ID,
                        principalTable: "RuleMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RuleDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Key = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    RuleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RuleDetails_Rules_RuleId",
                        column: x => x.RuleId,
                        principalTable: "Rules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RuleDetails_RuleId",
                table: "RuleDetails",
                column: "RuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_Mess_ID",
                table: "Rules",
                column: "Mess_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RuleDetails");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DropTable(
                name: "RuleMessages");
        }
    }
}
