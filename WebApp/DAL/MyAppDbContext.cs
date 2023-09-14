using Microsoft.EntityFrameworkCore;
using WebApp.Models.Entities;
namespace WebApp.DAL
{
    public class MyAppDbContext : DbContext
    {


        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }


        public virtual DbSet<User> Users { get; set; }
    }
}