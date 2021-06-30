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
                    TaskId = 1,
                    Description = "Discharge Summary",
                    CategoryID = 1,
                    Required = true
                },
                new Task
                {
                    TaskId = 2,
                    Description = "Aseptic Technique Before Surgery",
                    CategoryID = 2,
                    Required = true
                },
                new Task
                {
                    TaskId = 3,
                    Description = "Bone Density Study - Adult",
                    CategoryID = 3,
                    Required = false
                },
                new Task
                {
                    TaskId = 4,
                    Description = "ADD/ADHD Diagnosis - Child",
                    CategoryID = 4,
                    Required = true
                },
                new Task
                {
                    TaskId = 5,
                    Description = "History and Physical - Adult",
                    CategoryID = 1,
                    Required = true
                },
                new Task
                {
                    TaskId = 6,
                    Description = "Assist in Surgery",
                    CategoryID = 2,
                    Required = true
                },
                new Task
                {
                    TaskId = 7,
                    Description = "Apgar Score - Infant",
                    CategoryID = 3,
                    Required = true
                },
                new Task
                {
                    TaskId = 8,
                    Description = "ADD/ADHD Diagnosis - Adolescent",
                    CategoryID = 4,
                    Required = true
                },
                new Task
                {
                    TaskId = 9,
                    Description = "History and Physical - Infant",
                    CategoryID = 1,
                    Required = true
                },
                new Task
                {
                    TaskId = 10,
                    Description = "History and Physical - Child",
                    CategoryID = 1,
                    Required = true
                }
           );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1111111,
                    FirstName = "Dwayne 'The Rock'",
                    LastName = "Johnson",
                    Address = "123 Anywhere Street",
                    Email = "dw22@gmail.com",
                    Phone = "4358858888",
                    Role = "admin" 
                },
                new User
                {
                    UserId = 1111112,
                    FirstName = "Jaxon",
                    LastName = "Porter",
                    Address = "123 Anywhere Street",
                    Email = "jaxonutah@gmail.com",
                    Phone = "4352250000",
                    Role = "preceptor" 
                },
                new User
                {
                    UserId = 1111113,
                    FirstName = "Freddie",
                    LastName = "Mercury",
                    Address = "123 Anywhere Street",
                    Email = "fm@gmail.com",
                    Phone = "4358858888",
                    Role = "faculty" 
                },
                new User
                {
                    UserId = 1111114,
                    FirstName = "Henry",
                    LastName = "Spencer",
                    Address = "123 Anywhere Street",
                    Email = "dw22@gmail.com",
                    Phone = "4358858888",
                    Role = "student" 
                },
                new User
                {
                    UserId = 1111115,
                    FirstName = "Micheal",
                    LastName = "Scott",
                    Address = "1 Anywhere Street",
                    Email = "dw22@gmail.com",
                    Phone = "4358858889",
                    Role = "student" 
                },
                new User
                {
                    UserId = 1111116,
                    FirstName = "Creed",
                    LastName = "Bratton",
                    Address = "432 Anywhere Street",
                    Email = "cb@gmail.com",
                    Phone = "4358858888",
                    Role = "student" 
                },
                new User
                {
                    UserId = 1111117,
                    FirstName = "Phyllis",
                    LastName = "Vance",
                    Address = "123 Pensylvania ave",
                    Email = "pv@gmail.com",
                    Phone = "4358858888",
                    Role = "faculty" 
                }
            );

            modelBuilder.Entity<TaskCompletion>()
                .HasData(
                new TaskCompletion
                {
                    TaskCompletionId = 1,
                    TaskId = 1,
                    StudentUserId = 1111115,
                    FacultyUserId = 1111117,
                    PreceptorUserId = 1111112,
                    PreceptorInitial = "JP",
                    InitialDate = DateTime.Now,
                    TaskRating = 4
                },
                new TaskCompletion
                {
                    TaskCompletionId = 2,
                    TaskId = 2,
                    StudentUserId = 1111115,
                    FacultyUserId = 1111117,
                    PreceptorUserId = 1111112,
                    PreceptorInitial = "JP",
                    InitialDate = DateTime.Now,
                    TaskRating = 5
                },
                new TaskCompletion
                {
                    TaskCompletionId = 3,
                    TaskId = 4,
                    StudentUserId = 1111115,
                    FacultyUserId = 1111117,
                    PreceptorUserId = 1111112,
                    PreceptorInitial = "JP",
                    InitialDate = DateTime.Now,
                    TaskRating = 4
                },
                new TaskCompletion
                {
                    TaskCompletionId = 4,
                    TaskId = 5,
                    StudentUserId = 1111115,
                    FacultyUserId = 1111117,
                    PreceptorUserId = 1111112,
                    PreceptorInitial = "JP",
                    InitialDate = DateTime.Now,
                    TaskRating = 2
                },
                new TaskCompletion
                {
                    TaskCompletionId = 5,
                    TaskId = 1,
                    StudentUserId = 1111114,
                    FacultyUserId = 1111117,
                    PreceptorUserId = 1111112,
                    PreceptorInitial = "JP",
                    InitialDate = DateTime.Now,
                    TaskRating = 5
                },
                new TaskCompletion
                {
                    TaskCompletionId = 6,
                    TaskId = 9,
                    StudentUserId = 1111115,
                    FacultyUserId = 1111117,
                    PreceptorUserId = 1111112,
                    PreceptorInitial = "JP",
                    InitialDate = DateTime.Now,
                    TaskRating = 3
                }
            );
        }
    }
}