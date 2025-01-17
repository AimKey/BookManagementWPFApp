﻿// <auto-generated />
using System;
using BookManagement.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookManagement.DataAccess.Migrations
{
    [DbContext(typeof(BookManagementDbContext))]
    partial class BookManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookManagement.BusinessObjects.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorID"));

                    b.Property<DateTime?>("authorDOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("authorEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("authorImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("authorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookID"));

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<string>("BookImages")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookPDFLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiscountID")
                        .HasColumnType("int");

                    b.Property<int>("Language")
                        .HasColumnType("int");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("DiscountID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Discount", b =>
                {
                    b.Property<int>("DiscountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiscountID"));

                    b.Property<string>("discountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("discountValue")
                        .HasColumnType("float");

                    b.HasKey("DiscountID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Loan", b =>
                {
                    b.Property<int>("LoanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanID"));

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("Bookmark")
                        .HasColumnType("int");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("FineAmount")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("LoanID");

                    b.HasIndex("BookID");

                    b.HasIndex("UserID");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.LoanExtension", b =>
                {
                    b.Property<int>("LoanItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanItemID"));

                    b.Property<DateTime>("ExtendedDueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExtensionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LoanID")
                        .HasColumnType("int");

                    b.HasKey("LoanItemID");

                    b.HasIndex("LoanID");

                    b.ToTable("LoanExtensions");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShippingMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.OrderItem", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "BookID");

                    b.HasIndex("BookID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("Dob")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Book", b =>
                {
                    b.HasOne("BookManagement.BusinessObjects.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookManagement.BusinessObjects.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookManagement.BusinessObjects.Discount", "Discount")
                        .WithMany("Books")
                        .HasForeignKey("DiscountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("Discount");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Loan", b =>
                {
                    b.HasOne("BookManagement.BusinessObjects.Book", "Book")
                        .WithMany("Loans")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookManagement.BusinessObjects.User", "User")
                        .WithMany("Loans")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.LoanExtension", b =>
                {
                    b.HasOne("BookManagement.BusinessObjects.Loan", "Loan")
                        .WithMany("LoanExtensions")
                        .HasForeignKey("LoanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loan");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Order", b =>
                {
                    b.HasOne("BookManagement.BusinessObjects.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.OrderItem", b =>
                {
                    b.HasOne("BookManagement.BusinessObjects.Book", "Book")
                        .WithMany("OrderItems")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookManagement.BusinessObjects.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Book", b =>
                {
                    b.Navigation("Loans");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Discount", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Loan", b =>
                {
                    b.Navigation("LoanExtensions");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("BookManagement.BusinessObjects.User", b =>
                {
                    b.Navigation("Loans");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
