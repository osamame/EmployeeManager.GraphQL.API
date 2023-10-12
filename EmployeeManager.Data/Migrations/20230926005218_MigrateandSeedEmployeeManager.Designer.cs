﻿// <auto-generated />
using System;
using EmployeeManager.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManager.Data.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230926005218_MigrateandSeedEmployeeManager")]
    partial class MigrateandSeedEmployeeManager
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeManager.Data.Data.Department", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTime(2023, 9, 26, 1, 52, 18, 529, DateTimeKind.Local).AddTicks(7932),
                            DepartmentLocation = "Abuja",
                            DepartmentName = "Human Resource",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 26, 1, 52, 18, 529, DateTimeKind.Local).AddTicks(7940),
                            DepartmentLocation = "Abuja",
                            DepartmentName = "Admin Department",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3L,
                            DateCreated = new DateTime(2023, 9, 26, 1, 52, 18, 529, DateTimeKind.Local).AddTicks(7944),
                            DepartmentLocation = "Lagos",
                            DepartmentName = "Technical Department",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("EmployeeManager.Data.Data.Salary", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("MaximumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinimumSalary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Salaries");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTime(2023, 9, 26, 1, 52, 18, 529, DateTimeKind.Local).AddTicks(7375),
                            Grade = 1,
                            IsDeleted = false,
                            MaximumSalary = 2000000000.99m,
                            MinimumSalary = 1000000000.99m
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 26, 1, 52, 18, 529, DateTimeKind.Local).AddTicks(7383),
                            Grade = 2,
                            IsDeleted = false,
                            MaximumSalary = 3000000000.99m,
                            MinimumSalary = 2000000000.99m
                        },
                        new
                        {
                            Id = 3L,
                            DateCreated = new DateTime(2023, 9, 26, 1, 52, 18, 529, DateTimeKind.Local).AddTicks(7386),
                            Grade = 3,
                            IsDeleted = false,
                            MaximumSalary = 4000000000.99m,
                            MinimumSalary = 3000000000.99m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
