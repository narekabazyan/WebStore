using System.Data.Entity;

namespace WebStoreServer.Models
{
    public class WebStoreServerContext : DbContext
    {
        public WebStoreServerContext() : base("name=WebStoreServerContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
