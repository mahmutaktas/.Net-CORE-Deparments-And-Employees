﻿// <auto-generated />
using System;
using CoreDepartment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreDepartment.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200808093218_test_relation1")]
    partial class test_relation1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreDepartment.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName");

                    b.HasKey("ID");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("CoreDepartment.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmpCity");

                    b.Property<string>("EmpLastname");

                    b.Property<string>("EmpName");

                    b.Property<int?>("departID");

                    b.HasKey("ID");

                    b.HasIndex("departID");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("CoreDepartment.Models.Employee", b =>
                {
                    b.HasOne("CoreDepartment.Models.Department", "depart")
                        .WithMany("Employees")
                        .HasForeignKey("departID");
                });
#pragma warning restore 612, 618
        }
    }
}
