﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication4.Models;

namespace WebApplication4.Migrations
{
    [DbContext(typeof(ITIEntities))]
    partial class ITIEntitiesModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebApplication4.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Degree")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Department_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("minDegree")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("Department_ID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("WebApplication4.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Manager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("WebApplication4.Models.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Department_ID")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("Course_ID");

                    b.HasIndex("Department_ID");

                    b.ToTable("Instructor");
                });

            modelBuilder.Entity("WebApplication4.Models.Trainee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Department_ID")
                        .HasColumnType("int");

                    b.Property<decimal>("Grade")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Department_ID");

                    b.ToTable("Trainee");
                });

            modelBuilder.Entity("WebApplication4.Models.crsResult", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Trainee_ID")
                        .HasColumnType("int");

                    b.Property<decimal>("degree")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("Course_ID");

                    b.HasIndex("Trainee_ID");

                    b.ToTable("crsResult");
                });

            modelBuilder.Entity("WebApplication4.Models.Course", b =>
                {
                    b.HasOne("WebApplication4.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("Department_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("WebApplication4.Models.Instructor", b =>
                {
                    b.HasOne("WebApplication4.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication4.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("Department_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("WebApplication4.Models.Trainee", b =>
                {
                    b.HasOne("WebApplication4.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("Department_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("WebApplication4.Models.crsResult", b =>
                {
                    b.HasOne("WebApplication4.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication4.Models.Trainee", "Trainee")
                        .WithMany()
                        .HasForeignKey("Trainee_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Trainee");
                });
#pragma warning restore 612, 618
        }
    }
}
