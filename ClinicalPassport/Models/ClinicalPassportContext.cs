using System;
using Microsoft.EntityFrameworkCore;

namespace ClinicalPassport.Models
{
	public class ClinicalPassportContext : DbContext 
	{
        public ClinicalPassportContext(DbContextOptions<ClinicalPassportContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<TaskCompletion> TaskCompletions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 2,
                    Description = "Procedural"
                },
                new Category
                {
                    CategoryID = 3,
                    Description = "Screening"
                },
                new Category
                {
                    CategoryID = 4,
                    Description = "Diagnostic"
                },
                new Category
                {
                    CategoryID = 1,
                    Description = "Documentation"
                }
            );

            modelBuilder.Entity<Task>()
                .HasData(
                new Task
                {
                    TaskID = 1,
                    Description = "Discharge Summary",
                    CategoryID = 1,
                    Required = true
                },
                new Task
                {
                    TaskID = 2,
                    Description = "Aseptic Technique Before Surgery",
                    CategoryID = 2,
                    Required = true
                },
                new Task
                {
                    TaskID = 3,
                    Description = "Bone Density Study - Adult",
                    CategoryID = 3,
                    Required = false
                },
                new Task
                {
                    TaskID = 4,
                    Description = "ADD/ADHD Diagnosis - Child",
                    CategoryID = 4,
                    Required = true
                },
                new Task
                {
                    TaskID = 5,
                    Description = "History and Physical - Adult",
                    CategoryID = 1,
                    Required = true
                },
                new Task
                {
                    TaskID = 6,
                    Description = "Assist in Surgery",
                    CategoryID = 2,
                    Required = true
                },
                new Task
                {
                    TaskID = 7,
                    Description = "Apgar Score - Infant",
                    CategoryID = 3,
                    Required = true
                },
                new Task
                {
                    TaskID = 8,
                    Description = "ADD/ADHD Diagnosis - Adolescent",
                    CategoryID = 4,
                    Required = true
                },
                new Task
                {
                    TaskID = 9,
                    Description = "History and Physical - Infant",
                    CategoryID = 1,
                    Required = true
                },
                new Task
                {
                    TaskID = 10,
                    Description = "History and Physical - Child",
                    CategoryID = 1,
                    Required = true
                }
           );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserID = 1111111,
                    FirstName = "Dwayne 'The Rock'",
                    LastName = "Johnson",
                    Address = "123 Anywhere Street",
                    Email = "dw22@gmail.com",
                    Phone = "4358858888",
                    Role = "admin" 
                },
                new User
                {
                    UserID = 1111112,
                    FirstName = "Jaxon",
                    LastName = "Porter",
                    Address = "123 Anywhere Street",
                    Email = "jaxonutah@gmail.com",
                    Phone = "4352250000",
                    Role = "preceptor" 
                },
                new User
                {
                    UserID = 1111113,
                    FirstName = "Freddie",
                    LastName = "Mercury",
                    Address = "123 Anywhere Street",
                    Email = "fm@gmail.com",
                    Phone = "4358858888",
                    Role = "faculty" 
                },
                new User
                {
                    UserID = 1111114,
                    FirstName = "Henry",
                    LastName = "Spencer",
                    Address = "123 Anywhere Street",
                    Email = "dw22@gmail.com",
                    Phone = "4358858888",
                    Role = "student" 
                },
                new User
                {
                    UserID = 1111115,
                    FirstName = "Micheal",
                    LastName = "Scott",
                    Address = "1 Anywhere Street",
                    Email = "dw22@gmail.com",
                    Phone = "4358858889",
                    Role = "student" 
                },
                new User
                {
                    UserID = 1111116,
                    FirstName = "Creed",
                    LastName = "Bratton",
                    Address = "432 Anywhere Street",
                    Email = "cb@gmail.com",
                    Phone = "4358858888",
                    Role = "student" 
                },
                new User
                {
                    UserID = 1111117,
                    FirstName = "Phyllis",
                    LastName = "Vance",
                    Address = "123 Pensylvania ave",
                    Email = "pv@gmail.com",
                    Phone = "4358858888",
                    Role = "faculty" 
                }
            );

            modelBuilder.Entity<TaskCompletion>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(tc => tc.PreceptorUserID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<TaskCompletion>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(tc => tc.StudentUserID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<TaskCompletion>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(tc => tc.FacultyUserID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TaskCompletion>()
                .HasData(
                new TaskCompletion
                {
                    TaskCompletionID = 1,
                    TaskID = 1,
                    StudentUserID = 1111115,
                    FacultyUserID = 1111117,
                    PreceptorUserID = 1111112,
                    PreceptorInitial = "JP",
                    InitialDate = DateTime.Now,
                    TaskRating = 4
                },
                new TaskCompletion
                {
                    TaskCompletionID = 2,
                    TaskID = 2,
                    StudentUserID = 1111115,
                    FacultyUserID = 1111117,
                    PreceptorUserID = 1111112,
                    PreceptorInitial = "JP",
                    InitialDate = DateTime.Now,
                    TaskRating = 5
                },
                new TaskCompletion
                {
                    TaskCompletionID = 3,
                    TaskID = 4,
                    StudentUserID = 1111115,
                    FacultyUserID = 1111117,
                    PreceptorUserID = 1111112,
                    PreceptorInitial = "JP",
                    InitialDate = DateTime.Now,
                    TaskRating = 4
                },
                new TaskCompletion
                {
                    TaskCompletionID = 4,
                    TaskID = 5,
                    StudentUserID = 1111115,
                    FacultyUserID = 1111117,
                    PreceptorUserID = 1111112,
                    PreceptorInitial = "JP",
                    InitialDate = DateTime.Now,
                    TaskRating = 2
                },
                new TaskCompletion
                {
                    TaskCompletionID = 5,
                    TaskID = 1,
                    StudentUserID = 1111114,
                    FacultyUserID = 1111117,
                    PreceptorUserID = 1111112,
                    PreceptorInitial = "JP",
                    InitialDate = DateTime.Now,
                    TaskRating = 5
                },
                new TaskCompletion
                {
                    TaskCompletionID = 6,
                    TaskID = 9,
                    StudentUserID = 1111115,
                    FacultyUserID = 1111117,
                    PreceptorUserID = 1111112,
                    PreceptorInitial = "JP",
                    InitialDate = DateTime.Now,
                    TaskRating = 3
                }
            );
        }
    }
}