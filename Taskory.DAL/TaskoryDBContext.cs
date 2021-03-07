using System;
using Taskory.DAL.Models;
using Microsoft.EntityFrameworkCore;


namespace Taskory.DAL
{
    public class TaskoryDBContext : DbContext
    {
        public TaskoryDBContext()
            : base(new DbContextOptionsBuilder<TaskoryDBContext>().UseSqlServer("Server=localhost;Database=Taskory;User Id=sa;Password=Test1234").Options)
        {
        }

        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
