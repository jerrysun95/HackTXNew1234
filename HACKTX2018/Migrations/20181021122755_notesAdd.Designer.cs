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
    [Migration("20181021122755_notesAdd")]
    partial class notesAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("HACKTX2018.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FunderID");

                    b.Property<DateTime>("OrderDate");

                    b.HasKey("OrderID");

                    b.HasIndex("FunderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("HACKTX2018.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int?>("OrderID");

                    b.Property<int?>("OrganizationID");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("ShareAmount")
                        .IsRequired();

                    b.HasKey("OrderDetailID");

                    b.HasIndex("OrderID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("HACKTX2018.Models.Organization", b =>
                {
                    b.Property<int>("OrganizationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyValue")
                        .IsRequired();

                    b.Property<string>("Des");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("NumberShares")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<int?>("UserID");

                    b.HasKey("OrganizationID");

                    b.HasIndex("UserID");

                    b.ToTable("Organizations");
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

            modelBuilder.Entity("HACKTX2018.Models.Order", b =>
                {
                    b.HasOne("HACKTX2018.Models.Funder", "Funder")
                        .WithMany("Orders")
                        .HasForeignKey("FunderID");
                });

            modelBuilder.Entity("HACKTX2018.Models.OrderDetail", b =>
                {
                    b.HasOne("HACKTX2018.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID");

                    b.HasOne("HACKTX2018.Models.Organization", "Organization")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrganizationID");
                });

            modelBuilder.Entity("HACKTX2018.Models.Organization", b =>
                {
                    b.HasOne("HACKTX2018.Models.User", "User")
                        .WithMany("Organizations")
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}
