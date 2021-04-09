using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fichas.Migrations
{
    public partial class Message : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Msg = table.Column<string>(nullable: true),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    To = table.Column<Guid>(nullable: false),
                    From = table.Column<Guid>(nullable: false),
                    ToSee = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");
        }
    }
}
