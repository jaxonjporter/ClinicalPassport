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
        }
    }
}