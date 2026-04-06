using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MudBlazor;

namespace Portfolio.Data;
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Project> Projects { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Milestone> Milestones { get; set; }
    public DbSet<MilestoneType> MilestoneTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed our MilestoneTypes
        modelBuilder.Entity<MilestoneType>().HasData(
            new MilestoneType { ID = 1, Name = "Education", Icon = Icons.Material.Filled.School },
            new MilestoneType { ID = 2, Name = "Experience", Icon = Icons.Material.Filled.Work }
        );
    }
}