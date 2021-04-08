using System;
using Taskory.DAL.Models;
using Microsoft.EntityFrameworkCore;


namespace Taskory.DAL
{
    public class TaskoryDBContext : DbContext
    {
        public TaskoryDBContext()
            : base(new DbContextOptionsBuilder<TaskoryDBContext>().UseSqlServer("Server=den1.mssql8.gear.host;Database=Taskory;User Id=taskory;Password=Cl421Mx__Vmo").Options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
