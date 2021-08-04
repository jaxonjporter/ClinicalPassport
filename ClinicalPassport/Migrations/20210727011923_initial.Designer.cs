﻿// <auto-generated />
using System;
using ClinicalPassport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicalPassport.Migrations
{
    [DbContext(typeof(ClinicalPassportContext))]
    [Migration("20210727011923_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClinicalPassport.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 2,
                            Description = "Procedural"
                        },
                        new
                        {
                            CategoryID = 3,
                            Description = "Screening"
                        },
                        new
                        {
                            CategoryID = 4,
                            Description = "Diagnostic"
                        },
                        new
                        {
                            CategoryID = 1,
                            Description = "Documentation"
                        });
                });

            modelBuilder.Entity("ClinicalPassport.Models.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Required")
                        .HasColumnType("bit");

                    b.HasKey("TaskId");

                    b.HasIndex("CategoryID");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            TaskId = 1,
                            CategoryID = 1,
                            Description = "Discharge Summary",
                            Required = true
                        },
                        new
                        {
                            TaskId = 2,
                            CategoryID = 2,
                            Description = "Aseptic Technique Before Surgery",
                            Required = true
                        },
                        new
                        {
                            TaskId = 3,
                            CategoryID = 3,
                            Description = "Bone Density Study - Adult",
                            Required = false
                        },
                        new
                        {
                            TaskId = 4,
                            CategoryID = 4,
                            Description = "ADD/ADHD Diagnosis - Child",
                            Required = true
                        },
                        new
                        {
                            TaskId = 5,
                            CategoryID = 1,
                            Description = "History and Physical - Adult",
                            Required = true
                        },
                        new
                        {
                            TaskId = 6,
                            CategoryID = 2,
                            Description = "Assist in Surgery",
                            Required = true
                        },
                        new
                        {
                            TaskId = 7,
                            CategoryID = 3,
                            Description = "Apgar Score - Infant",
                            Required = true
                        },
                        new
                        {
                            TaskId = 8,
                            CategoryID = 4,
                            Description = "ADD/ADHD Diagnosis - Adolescent",
                            Required = true
                        },
                        new
                        {
                            TaskId = 9,
                            CategoryID = 1,
                            Description = "History and Physical - Infant",
                            Required = true
                        },
                        new
                        {
                            TaskId = 10,
                            CategoryID = 1,
                            Description = "History and Physical - Child",
                            Required = true
                        });
                });

            modelBuilder.Entity("ClinicalPassport.Models.TaskCompletion", b =>
                {
                    b.Property<int>("TaskCompletionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacultyUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PreceptorInitial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PreceptorUserId")
                        .HasColumnType("int");

                    b.Property<int>("StudentUserId")
                        .HasColumnType("int");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.Property<int>("TaskRating")
                        .HasColumnType("int");

                    b.HasKey("TaskCompletionId");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskCompletions");

                    b.HasData(
                        new
                        {
                            TaskCompletionId = 1,
                            FacultyUserId = 1111117,
                            InitialDate = new DateTime(2021, 7, 26, 20, 19, 23, 39, DateTimeKind.Local).AddTicks(8999),
                            PreceptorInitial = "JP",
                            PreceptorUserId = 1111112,
                            StudentUserId = 1111115,
                            TaskId = 1,
                            TaskRating = 4
                        },
                        new
                        {
                            TaskCompletionId = 2,
                            FacultyUserId = 1111117,
                            InitialDate = new DateTime(2021, 7, 26, 20, 19, 23, 41, DateTimeKind.Local).AddTicks(7812),
                            PreceptorInitial = "JP",
                            PreceptorUserId = 1111112,
                            StudentUserId = 1111115,
                            TaskId = 2,
                            TaskRating = 5
                        },
                        new
                        {
                            TaskCompletionId = 3,
                            FacultyUserId = 1111117,
                            InitialDate = new DateTime(2021, 7, 26, 20, 19, 23, 41, DateTimeKind.Local).AddTicks(7844),
                            PreceptorInitial = "JP",
                            PreceptorUserId = 1111112,
                            StudentUserId = 1111115,
                            TaskId = 4,
                            TaskRating = 4
                        },
                        new
                        {
                            TaskCompletionId = 4,
                            FacultyUserId = 1111117,
                            InitialDate = new DateTime(2021, 7, 26, 20, 19, 23, 41, DateTimeKind.Local).AddTicks(7849),
                            PreceptorInitial = "JP",
                            PreceptorUserId = 1111112,
                            StudentUserId = 1111115,
                            TaskId = 5,
                            TaskRating = 2
                        },
                        new
                        {
                            TaskCompletionId = 5,
                            FacultyUserId = 1111117,
                            InitialDate = new DateTime(2021, 7, 26, 20, 19, 23, 41, DateTimeKind.Local).AddTicks(7852),
                            PreceptorInitial = "JP",
                            PreceptorUserId = 1111112,
                            StudentUserId = 1111114,
                            TaskId = 1,
                            TaskRating = 5
                        },
                        new
                        {
                            TaskCompletionId = 6,
                            FacultyUserId = 1111117,
                            InitialDate = new DateTime(2021, 7, 26, 20, 19, 23, 41, DateTimeKind.Local).AddTicks(7855),
                            PreceptorInitial = "JP",
                            PreceptorUserId = 1111112,
                            StudentUserId = 1111115,
                            TaskId = 9,
                            TaskRating = 3
                        });
                });

            modelBuilder.Entity("ClinicalPassport.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1111111,
                            Address = "123 Anywhere Street",
                            Email = "dw22@gmail.com",
                            FirstName = "Dwayne 'The Rock'",
                            LastName = "Johnson",
                            Phone = "4358858888",
                            Role = "admin"
                        },
                        new
                        {
                            UserId = 1111112,
                            Address = "123 Anywhere Street",
                            Email = "jaxonutah@gmail.com",
                            FirstName = "Jaxon",
                            LastName = "Porter",
                            Phone = "4352250000",
                            Role = "preceptor"
                        },
                        new
                        {
                            UserId = 1111113,
                            Address = "123 Anywhere Street",
                            Email = "fm@gmail.com",
                            FirstName = "Freddie",
                            LastName = "Mercury",
                            Phone = "4358858888",
                            Role = "faculty"
                        },
                        new
                        {
                            UserId = 1111114,
                            Address = "123 Anywhere Street",
                            Email = "dw22@gmail.com",
                            FirstName = "Henry",
                            LastName = "Spencer",
                            Phone = "4358858888",
                            Role = "student"
                        },
                        new
                        {
                            UserId = 1111115,
                            Address = "1 Anywhere Street",
                            Email = "dw22@gmail.com",
                            FirstName = "Micheal",
                            LastName = "Scott",
                            Phone = "4358858889",
                            Role = "student"
                        },
                        new
                        {
                            UserId = 1111116,
                            Address = "432 Anywhere Street",
                            Email = "cb@gmail.com",
                            FirstName = "Creed",
                            LastName = "Bratton",
                            Phone = "4358858888",
                            Role = "student"
                        },
                        new
                        {
                            UserId = 1111117,
                            Address = "123 Pensylvania ave",
                            Email = "pv@gmail.com",
                            FirstName = "Phyllis",
                            LastName = "Vance",
                            Phone = "4358858888",
                            Role = "faculty"
                        });
                });

            modelBuilder.Entity("ClinicalPassport.Models.Task", b =>
                {
                    b.HasOne("ClinicalPassport.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ClinicalPassport.Models.TaskCompletion", b =>
                {
                    b.HasOne("ClinicalPassport.Models.Task", "Task")
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });
#pragma warning restore 612, 618
        }
    }
}