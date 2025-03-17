using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        // Database initialization code here, if any
    }

    public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<University> Universities { get; set; } = null!;
    public DbSet<Department> Departments { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>()
            .HasOne(d => d.University)
            .WithMany(u => u.Departments)
            .HasForeignKey(d => d.UniversityId);

        modelBuilder.Entity<Course>()
            .HasOne(c => c.Department)
            .WithMany(d => d.Courses)
            .HasForeignKey(c => c.DepartmentId);
    }
}
