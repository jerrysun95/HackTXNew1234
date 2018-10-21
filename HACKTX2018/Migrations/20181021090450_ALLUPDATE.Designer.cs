﻿// <auto-generated />
using System;
using HACKTX2018.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HACKTX2018.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181021090450_ALLUPDATE")]
    partial class ALLUPDATE
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HACKTX2018.Model.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FunderID");

                    b.Property<DateTime>("OrderDate");

                    b.HasKey("OrderID");

                    b.HasIndex("FunderID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("HACKTX2018.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyValue")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("NumberShares")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<int?>("UserID");

                    b.HasKey("CompanyID");

                    b.HasIndex("UserID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("HACKTX2018.Models.Funder", b =>
                {
                    b.Property<int>("FunderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreditCard")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.HasKey("FunderID");

                    b.ToTable("Funders");
                });

            modelBuilder.Entity("HACKTX2018.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ComapnyCompanyID");

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int?>("OrderID");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("ShareAmount")
                        .IsRequired();

                    b.HasKey("OrderDetailID");

                    b.HasIndex("ComapnyCompanyID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("HACKTX2018.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HACKTX2018.Model.Order", b =>
                {
                    b.HasOne("HACKTX2018.Models.Funder", "Funder")
                        .WithMany("Orders")
                        .HasForeignKey("FunderID");
                });

            modelBuilder.Entity("HACKTX2018.Models.Company", b =>
                {
                    b.HasOne("HACKTX2018.Models.User", "User")
                        .WithMany("Companies")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("HACKTX2018.Models.OrderDetail", b =>
                {
                    b.HasOne("HACKTX2018.Models.Company", "Comapny")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ComapnyCompanyID");

                    b.HasOne("HACKTX2018.Model.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID");
                });
#pragma warning restore 612, 618
        }
    }
}
