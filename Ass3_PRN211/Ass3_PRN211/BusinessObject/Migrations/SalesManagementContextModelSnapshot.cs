﻿// <auto-generated />
using System;
using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessObject.Migrations
{
    [DbContext(typeof(SalesManagementContext))]
    partial class SalesManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusinessObject.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("MemberId");

                    b.ToTable("Members", (string)null);
                });

            modelBuilder.Entity("BusinessObject.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<decimal?>("Freight")
                        .HasColumnType("money");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("RequiredDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("datetime");

                    b.HasKey("OrderId");

                    b.HasIndex("MemberId");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("BusinessObject.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.HasKey("OrderId", "ProductId")
                        .HasName("PK__OrderDet__C3905BCFD5234EF6");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails", (string)null);
                });

            modelBuilder.Entity("BusinessObject.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<short>("CategoryId")
                        .HasColumnType("smallint");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("money");

                    b.Property<short>("UnitsInStock")
                        .HasColumnType("smallint");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ProductId");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("BusinessObject.Order", b =>
                {
                    b.HasOne("BusinessObject.Member", "Member")
                        .WithMany("Orders")
                        .HasForeignKey("MemberId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_Member");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("BusinessObject.OrderDetail", b =>
                {
                    b.HasOne("BusinessObject.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetail_Order");

                    b.HasOne("BusinessObject.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetail_Product");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BusinessObject.Member", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BusinessObject.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BusinessObject.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}