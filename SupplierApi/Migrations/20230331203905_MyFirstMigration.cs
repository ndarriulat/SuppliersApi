//using Microsoft.EntityFrameworkCore.Migrations;

//#nullable disable

//namespace SupplierApi.Migrations
//{
//    public partial class MyFirstMigration : Migration
//    {
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.CreateTable(
//                name: "Supplier",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Supplier", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "Product",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
//                    Price = table.Column<int>(type: "int", nullable: false),
//                    SupplierId = table.Column<int>(type: "int", nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Product", x => x.Id);
//                    table.ForeignKey(
//                        name: "FK_Product_Supplier_SupplierId",
//                        column: x => x.SupplierId,
//                        principalTable: "Supplier",
//                        principalColumn: "Id");
//                });

//            migrationBuilder.CreateIndex(
//                name: "IX_Product_SupplierId",
//                table: "Product",
//                column: "SupplierId");
//        }

//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropTable(
//                name: "Product");

//            migrationBuilder.DropTable(
//                name: "Supplier");
//        }
//    }
//}
