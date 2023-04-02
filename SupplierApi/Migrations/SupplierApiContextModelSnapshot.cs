﻿//// <auto-generated />
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
//using SupplierApi.Data;

//#nullable disable

//namespace SupplierApi.Migrations
//{
//    [DbContext(typeof(SupplierApiContext))]
//    partial class SupplierApiContextModelSnapshot : ModelSnapshot
//    {
//        protected override void BuildModel(ModelBuilder modelBuilder)
//        {
//#pragma warning disable 612, 618
//            modelBuilder
//                .HasAnnotation("ProductVersion", "6.0.15")
//                .HasAnnotation("Relational:MaxIdentifierLength", 128);

//            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

//            modelBuilder.Entity("SupplierApi.Product", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int");

//                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

//                    b.Property<string>("Name")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<int>("Price")
//                        .HasColumnType("int");

//                    b.Property<int>("SupplierId")
//                        .HasColumnType("int");

//                    b.HasKey("Id");

//                    b.HasIndex("SupplierId");

//                    b.ToTable("Product");
//                });

//            modelBuilder.Entity("SupplierApi.Supplier", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int");

//                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

//                    b.Property<string>("Description")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("Name")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.HasKey("Id");

//                    b.ToTable("Supplier");
//                });

//            modelBuilder.Entity("SupplierApi.Product", b =>
//                {
//                    b.HasOne("SupplierApi.Supplier", null)
//                        .WithMany("Products")
//                        .HasForeignKey("SupplierId")
//                        .OnDelete(DeleteBehavior.Cascade)
//                        .IsRequired();
//                });

//            modelBuilder.Entity("SupplierApi.Supplier", b =>
//                {
//                    b.Navigation("Products");
//                });
//#pragma warning restore 612, 618
//        }
//    }
//}
