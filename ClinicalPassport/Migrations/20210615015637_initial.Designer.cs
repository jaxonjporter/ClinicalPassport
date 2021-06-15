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
    [Migration("20210615015637_initial")]
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
                    b.Property<int>("TaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Required")
                        .HasColumnType("bit");

                    b.HasKey("TaskID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            TaskID = 1,
                            CategoryID = 1,
                            Description = "Discharge Summary",
                            Required = true
                        },
                        new
                        {
                            TaskID = 2,
                            CategoryID = 2,
                            Description = "Aseptic Technique Before Surgery",
                            Required = true
                        },
                        new
                        {
                            TaskID = 3,
                            CategoryID = 3,
                            Description = "Bone Density Study - Adult",
                            Required = false
                        },
                        new
                        {
                            TaskID = 4,
                            CategoryID = 4,
                            Description = "ADD/ADHD Diagnosis - Child",
                            Required = true
                        },
                        new
                        {
                            TaskID = 5,
                            CategoryID = 1,
                            Description = "History and Physical - Adult",
                            Required = true
                        },
                        new
                        {
                            TaskID = 6,
                            CategoryID = 2,
                            Description = "Assist in Surgery",
                            Required = true
                        },
                        new
                        {
                            TaskID = 7,
                            CategoryID = 3,
                            Description = "Apgar Score - Infant",
                            Required = true
                        },
                        new
                        {
                            TaskID = 8,
                            CategoryID = 4,
                            Description = "ADD/ADHD Diagnosis - Adolescent",
                            Required = true
                        },
                        new
                        {
                            TaskID = 9,
                            CategoryID = 1,
                            Description = "History and Physical - Infant",
                            Required = true
                        },
                        new
                        {
                            TaskID = 10,
                            CategoryID = 1,
                            Description = "History and Physical - Child",
                            Required = true
                        });
                });

            modelBuilder.Entity("ClinicalPassport.Models.TaskCompletion", b =>
                {
                    b.Property<int>("TaskCompletionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacultyUserID")
                        .HasColumnType("int");

                    b.Property<int?>("FacultyUserID1")
                        .HasColumnType("int");

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PreceptorInitial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PreceptorUserID")
                        .HasColumnType("int");

                    b.Property<int?>("PreceptorUserID1")
                        .HasColumnType("int");

                    b.Property<int>("StudentUserID")
                        .HasColumnType("int");

                    b.Property<int?>("StudentUserID1")
                        .HasColumnType("int");

                    b.Property<int>("TaskID")
                        .HasColumnType("int");

                    b.Property<int>("TaskRating")
                        .HasColumnType("int");

                    b.HasKey("TaskCompletionID");

                    b.HasIndex("FacultyUserID");

                    b.HasIndex("FacultyUserID1");

                    b.HasIndex("PreceptorUserID");

                    b.HasIndex("PreceptorUserID1");

                    b.HasIndex("StudentUserID");

                    b.HasIndex("StudentUserID1");

                    b.HasIndex("TaskID");

                    b.ToTable("TaskCompletions");

                    b.HasData(
                        new
                        {
                            TaskCompletionID = 1,
                            FacultyUserID = 1111117,
                            InitialDate = new DateTime(2021, 6, 14, 19, 56, 36, 935, DateTimeKind.Local).AddTicks(8533),
                            PreceptorInitial = "JP",
                            PreceptorUserID = 1111112,
                            StudentUserID = 1111115,
                            TaskID = 1,
                            TaskRating = 4
                        },
                        new
                        {
                            TaskCompletionID = 2,
                            FacultyUserID = 1111117,
                            InitialDate = new DateTime(2021, 6, 14, 19, 56, 36, 938, DateTimeKind.Local).AddTicks(2792),
                            PreceptorInitial = "JP",
                            PreceptorUserID = 1111112,
                            StudentUserID = 1111115,
                            TaskID = 2,
                            TaskRating = 5
                        },
                        new
                        {
                            TaskCompletionID = 3,
                            FacultyUserID = 1111117,
                            InitialDate = new DateTime(2021, 6, 14, 19, 56, 36, 938, DateTimeKind.Local).AddTicks(2840),
                            PreceptorInitial = "JP",
                            PreceptorUserID = 1111112,
                            StudentUserID = 1111115,
                            TaskID = 4,
                            TaskRating = 4
                        },
                        new
                        {
                            TaskCompletionID = 4,
                            FacultyUserID = 1111117,
                            InitialDate = new DateTime(2021, 6, 14, 19, 56, 36, 938, DateTimeKind.Local).AddTicks(2844),
                            PreceptorInitial = "JP",
                            PreceptorUserID = 1111112,
                            StudentUserID = 1111115,
                            TaskID = 5,
                            TaskRating = 2
                        },
                        new
                        {
                            TaskCompletionID = 5,
                            FacultyUserID = 1111117,
                            InitialDate = new DateTime(2021, 6, 14, 19, 56, 36, 938, DateTimeKind.Local).AddTicks(2847),
                            PreceptorInitial = "JP",
                            PreceptorUserID = 1111112,
                            StudentUserID = 1111114,
                            TaskID = 1,
                            TaskRating = 5
                        },
                        new
                        {
                            TaskCompletionID = 6,
                            FacultyUserID = 1111117,
                            InitialDate = new DateTime(2021, 6, 14, 19, 56, 36, 938, DateTimeKind.Local).AddTicks(2851),
                            PreceptorInitial = "JP",
                            PreceptorUserID = 1111112,
                            StudentUserID = 1111115,
                            TaskID = 9,
                            TaskRating = 3
                        });
                });

            modelBuilder.Entity("ClinicalPassport.Models.User", b =>
                {
                    b.Property<int>("UserID")
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

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1111111,
                            Address = "123 Anywhere Street",
                            Email = "dw22@gmail.com",
                            FirstName = "Dwayne 'The Rock'",
                            LastName = "Johnson",
                            Phone = "4358858888",
                            Role = "admin"
                        },
                        new
                        {
                            UserID = 1111112,
                            Address = "123 Anywhere Street",
                            Email = "jaxonutah@gmail.com",
                            FirstName = "Jaxon",
                            LastName = "Porter",
                            Phone = "4352250000",
                            Role = "preceptor"
                        },
                        new
                        {
                            UserID = 1111113,
                            Address = "123 Anywhere Street",
                            Email = "fm@gmail.com",
                            FirstName = "Freddie",
                            LastName = "Mercury",
                            Phone = "4358858888",
                            Role = "faculty"
                        },
                        new
                        {
                            UserID = 1111114,
                            Address = "123 Anywhere Street",
                            Email = "dw22@gmail.com",
                            FirstName = "Henry",
                            LastName = "Spencer",
                            Phone = "4358858888",
                            Role = "student"
                        },
                        new
                        {
                            UserID = 1111115,
                            Address = "1 Anywhere Street",
                            Email = "dw22@gmail.com",
                            FirstName = "Micheal",
                            LastName = "Scott",
                            Phone = "4358858889",
                            Role = "student"
                        },
                        new
                        {
                            UserID = 1111116,
                            Address = "432 Anywhere Street",
                            Email = "cb@gmail.com",
                            FirstName = "Creed",
                            LastName = "Bratton",
                            Phone = "4358858888",
                            Role = "student"
                        },
                        new
                        {
                            UserID = 1111117,
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
                    b.HasOne("ClinicalPassport.Models.User", null)
                        .WithMany()
                        .HasForeignKey("FacultyUserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ClinicalPassport.Models.User", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyUserID1");

                    b.HasOne("ClinicalPassport.Models.User", null)
                        .WithMany()
                        .HasForeignKey("PreceptorUserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ClinicalPassport.Models.User", "Preceptor")
                        .WithMany()
                        .HasForeignKey("PreceptorUserID1");

                    b.HasOne("ClinicalPassport.Models.User", null)
                        .WithMany()
                        .HasForeignKey("StudentUserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ClinicalPassport.Models.User", "Student")
                        .WithMany()
                        .HasForeignKey("StudentUserID1");

                    b.HasOne("ClinicalPassport.Models.Task", "Task")
                        .WithMany("TaskCompletions")
                        .HasForeignKey("TaskID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("Preceptor");

                    b.Navigation("Student");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("ClinicalPassport.Models.Task", b =>
                {
                    b.Navigation("TaskCompletions");
                });
#pragma warning restore 612, 618
        }
    }
}
