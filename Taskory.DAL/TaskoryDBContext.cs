using System;
using Microsoft.EntityFrameworkCore;


namespace Taskory.DAL
{
    public class TaskoryDBContext : DbContext
    {
        public TaskoryDBContext(string connectionString)
            : base(new DbContextOptionsBuilder<TaskoryDBContext>().UseSqlServer(new AppSettings().ConnectionString).Options)
        {
        }
    }
}
