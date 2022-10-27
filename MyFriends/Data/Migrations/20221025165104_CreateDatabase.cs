using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFriends.Data.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(name: "Full Name", type: "TEXT", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Age", "Full Name" },
                values: new object[] { 1, 30, "Hossein Parsa" });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Age", "Full Name" },
                values: new object[] { 2, 18, "Ilnaz Alizadeh" });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Age", "Full Name" },
                values: new object[] { 3, 35, "Amir Sharifi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friends");
        }
    }
}
