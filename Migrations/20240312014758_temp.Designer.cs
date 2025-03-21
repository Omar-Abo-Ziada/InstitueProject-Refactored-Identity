﻿// <auto-generated />
using System;
using InstitueProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using InstitueProject.Context;


#nullable disable

namespace InstitueProject.Migrations
{
    [DbContext(typeof(ITIContext))]
    [Migration("20240312014758_temp")]
    partial class temp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InstitueProject.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<int>("MinDegree")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Degree = 150,
                            DepartmentId = 1,
                            Hours = 60,
                            MinDegree = 80,
                            Name = "MVC"
                        },
                        new
                        {
                            Id = 2,
                            Degree = 100,
                            DepartmentId = 2,
                            Hours = 40,
                            MinDegree = 60,
                            Name = "Data base"
                        },
                        new
                        {
                            Id = 3,
                            Degree = 80,
                            DepartmentId = 3,
                            Hours = 35,
                            MinDegree = 50,
                            Name = "Cloud computing"
                        });
                });

            modelBuilder.Entity("InstitueProject.Models.CourseResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int>("TraineeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TraineeId");

                    b.ToTable("CourseResult");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Degree = 75,
                            TraineeId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            Degree = 80,
                            TraineeId = 2
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 3,
                            Degree = 60,
                            TraineeId = 3
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 1,
                            Degree = 90,
                            TraineeId = 4
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 2,
                            Degree = 55,
                            TraineeId = 5
                        });
                });

            modelBuilder.Entity("InstitueProject.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ManagerName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ManagerName = "Hany",
                            Name = "SD"
                        },
                        new
                        {
                            Id = 2,
                            ManagerName = "Mohamed",
                            Name = "Ui/UX"
                        },
                        new
                        {
                            Id = 3,
                            ManagerName = "Joshphene",
                            Name = "Open Source"
                        },
                        new
                        {
                            Id = 4,
                            ManagerName = "Alaa",
                            Name = "BI"
                        },
                        new
                        {
                            Id = 5,
                            ManagerName = "Wael",
                            Name = "Devops"
                        });
                });

            modelBuilder.Entity("InstitueProject.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Instructor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "Sohag",
                            CourseId = 1,
                            DepartmentId = 1,
                            ImageUrl = "1.jpg",
                            Name = "Hany",
                            Salary = 20000m
                        },
                        new
                        {
                            Id = 2,
                            Adress = "Assiut",
                            CourseId = 1,
                            DepartmentId = 2,
                            ImageUrl = "2.jpg",
                            Name = "Mohamed",
                            Salary = 15000m
                        },
                        new
                        {
                            Id = 3,
                            Adress = "Alex",
                            CourseId = 2,
                            DepartmentId = 3,
                            ImageUrl = "3.jpg",
                            Name = "Joshphene",
                            Salary = 10000m
                        },
                        new
                        {
                            Id = 4,
                            Adress = "Cairo",
                            CourseId = 2,
                            DepartmentId = 4,
                            ImageUrl = "4.jpg",
                            Name = "Alaa",
                            Salary = 35000m
                        },
                        new
                        {
                            Id = 5,
                            Adress = "Aswan",
                            CourseId = 3,
                            DepartmentId = 5,
                            ImageUrl = "5.jpg",
                            Name = "Wael",
                            Salary = 25000m
                        });
                });

            modelBuilder.Entity("InstitueProject.Models.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Trainee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Grade = 1,
                            ImageUrl = "6.jpg",
                            Name = "Emad"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            Grade = 2,
                            ImageUrl = "7.jpg",
                            Name = "Hesham"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 3,
                            Grade = 1,
                            ImageUrl = "8.jpg",
                            Name = "Sara"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 4,
                            Grade = 3,
                            ImageUrl = "9.jpg",
                            Name = "smeer"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 5,
                            Grade = 4,
                            ImageUrl = "10.jpg",
                            Name = "Amr"
                        });
                });

            modelBuilder.Entity("InstitueProject.Models.Course", b =>
                {
                    b.HasOne("InstitueProject.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("InstitueProject.Models.CourseResult", b =>
                {
                    b.HasOne("InstitueProject.Models.Course", "Course")
                        .WithMany("CourseResult")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InstitueProject.Models.Trainee", "Trainee")
                        .WithMany("CourseResult")
                        .HasForeignKey("TraineeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("InstitueProject.Models.Instructor", b =>
                {
                    b.HasOne("InstitueProject.Models.Course", "Course")
                        .WithMany("Instructors")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InstitueProject.Models.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("InstitueProject.Models.Trainee", b =>
                {
                    b.HasOne("InstitueProject.Models.Department", "Department")
                        .WithMany("Trainees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("InstitueProject.Models.Course", b =>
                {
                    b.Navigation("CourseResult");

                    b.Navigation("Instructors");
                });

            modelBuilder.Entity("InstitueProject.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Instructors");

                    b.Navigation("Trainees");
                });

            modelBuilder.Entity("InstitueProject.Models.Trainee", b =>
                {
                    b.Navigation("CourseResult");
                });
#pragma warning restore 612, 618
        }
    }
}
