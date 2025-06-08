using API.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace API.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
