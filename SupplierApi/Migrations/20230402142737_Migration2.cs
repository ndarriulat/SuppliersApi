//using Microsoft.EntityFrameworkCore.Migrations;

//#nullable disable

//namespace SupplierApi.Migrations
//{
//    public partial class Migration2 : Migration
//    {
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropForeignKey(
//                name: "FK_Product_Supplier_SupplierId",
//                table: "Product");

//            migrationBuilder.AlterColumn<int>(
//                name: "SupplierId",
//                table: "Product",
//                type: "int",
//                nullable: false,
//                defaultValue: 0,
//                oldClrType: typeof(int),
//                oldType: "int",
//                oldNullable: true);

//            migrationBuilder.AlterColumn<string>(
//                name: "Name",
//                table: "Product",
//                type: "nvarchar(max)",
//                nullable: true,
//                oldClrType: typeof(string),
//                oldType: "nvarchar(max)");

//            migrationBuilder.AddForeignKey(
//                name: "FK_Product_Supplier_SupplierId",
//                table: "Product",
//                column: "SupplierId",
//                principalTable: "Supplier",
//                principalColumn: "Id",
//                onDelete: ReferentialAction.Cascade);
//        }

//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropForeignKey(
//                name: "FK_Product_Supplier_SupplierId",
//                table: "Product");

//            migrationBuilder.AlterColumn<int>(
//                name: "SupplierId",
//                table: "Product",
//                type: "int",
//                nullable: true,
//                oldClrType: typeof(int),
//                oldType: "int");

//            migrationBuilder.AlterColumn<string>(
//                name: "Name",
//                table: "Product",
//                type: "nvarchar(max)",
//                nullable: false,
//                defaultValue: "",
//                oldClrType: typeof(string),
//                oldType: "nvarchar(max)",
//                oldNullable: true);

//            migrationBuilder.AddForeignKey(
//                name: "FK_Product_Supplier_SupplierId",
//                table: "Product",
//                column: "SupplierId",
//                principalTable: "Supplier",
//                principalColumn: "Id");
//        }
//    }
//}
