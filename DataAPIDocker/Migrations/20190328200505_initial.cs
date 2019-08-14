using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAPIDocker.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Captains",
                columns: table => new
                {
                    CaptainId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Captains", x => x.CaptainId);
                });

            migrationBuilder.InsertData(
                table: "Captains",
                columns: new[] { "CaptainId", "Name" },
                values: new object[,]
                {
                    { 1, "Julie Lerman" },
                    { 2, "Rachid Zarouali" },
                    { 3, "Michele Bustamante" },
                    { 4, "Dan Wahlin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Captains");
        }
    }
}
