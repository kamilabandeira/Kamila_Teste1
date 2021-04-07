using Microsoft.EntityFrameworkCore;
using System;

namespace KT1.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) : base(options)
        {
        } 
        public DbSet<Student> Student { get; set; }
    }
}
