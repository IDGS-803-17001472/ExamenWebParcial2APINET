using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APITienda.Migrations
{
    /// <inheritdoc />
    public partial class AddDescripcionATenis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tenis",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "varchar(355)", unicode: false, maxLength: 355, nullable: true),
                    precio = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    categoria = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    imagen = table.Column<string>(type: "varchar(355)", unicode: false, maxLength: 355, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tenis__3213E83F02902286", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tenis");
        }
    }
}
