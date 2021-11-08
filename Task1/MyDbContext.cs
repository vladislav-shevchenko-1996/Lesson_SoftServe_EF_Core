using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
   public class MyDbContext:DbContext
    {
        public MyDbContext()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyCompanyDb;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Worker> Workers { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    
    //Entites

    public class Worker
    {
        public int Id { get; set; }
        [Required]//not null
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        [Required]
        public Department Department { get; set; }
        [Required]
        public Country Country { get; set; }
        public ICollection<Project> Projects { get; set; }

    }
    public class Country
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Worker> Workers { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        //Navigation Properties
        public ICollection<Worker> Workers { get; set; }
    }

    public class Project
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime? LaunchDate { get; set; }
        public ICollection<Worker> Workers { get; set; }


    }
}
