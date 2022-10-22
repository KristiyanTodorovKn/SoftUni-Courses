using ForumApp.Data.Configuration;
using ForumApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data
{
    public class ForumAppDbContext : DbContext
    {
        public ForumAppDbContext (DbContextOptions<ForumAppDbContext> options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PostConfiguration());
            builder.Entity<Post>()
                .Property(p => p.isDeleted)
                .HasDefaultValue(false);

            base.OnModelCreating(builder);
        }
        public DbSet<Post> Posts { get; set; }
    }
}
