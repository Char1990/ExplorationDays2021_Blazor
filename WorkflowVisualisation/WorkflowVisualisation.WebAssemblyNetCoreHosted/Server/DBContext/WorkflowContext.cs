using Microsoft.EntityFrameworkCore;
using WorkflowVisualisation.WebAssemblyNetCoreHosted.Shared;

namespace WorkflowVisualisation.WebAssemblyNetCoreHosted.Server.DBContext
{
    public class WorkflowContext : DbContext
    {
        public WorkflowContext()
        {
        }

        public WorkflowContext(DbContextOptions<WorkflowContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Workflow> Workflows { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workflow>(entity =>
            {
                entity.ToTable("Workflow");
            });

        }
    }
}
