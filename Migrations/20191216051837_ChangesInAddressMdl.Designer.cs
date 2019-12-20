﻿// <auto-generated />
using EmployeeMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeMVC.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20191216051837_ChangesInAddressMdl")]
    partial class ChangesInAddressMdl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeMVC.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpID")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressID");

                    b.HasIndex("EmpID")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("EmployeeMVC.Models.Employee", b =>
                {
                    b.Property<int>("EmpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EmployeeMVC.Models.Address", b =>
                {
                    b.HasOne("EmployeeMVC.Models.Employee", "Employee")
                        .WithOne("Addresses")
                        .HasForeignKey("EmployeeMVC.Models.Address", "EmpID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
