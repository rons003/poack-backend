using Microsoft.EntityFrameworkCore;
namespace poack.Model {
    public partial class DesContext : DbContext {
        public DesContext (DbContextOptions<DesContext> options) : base (options) { }

        public DbSet<Blog> Blogs { get; set; }
    }
}