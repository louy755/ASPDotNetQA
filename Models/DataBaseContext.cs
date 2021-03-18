using System;
using Microsoft.EntityFrameworkCore;

namespace ASPDotNET.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Question> Questions { get; set; }
    }

}
