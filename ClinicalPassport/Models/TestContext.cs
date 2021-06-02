using System;
using Microsoft.EntityFrameworkCore;

namespace ClinicalPassport.Models
{
	public class TestContext : DbContext 
	{
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        { }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentID = 13512,
                    Name = "Dwayne 'The Rock' Johnson",
                    DOB = DateTime.Today,
                    Address = "123 Nowhere"
                }
            );
        }
    }
}