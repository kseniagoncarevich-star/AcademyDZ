using Microsoft.EntityFrameworkCore;

public class AcademyDZContext(DbContextOptions<AcademyDZContext> options) : DbContext(options)
{
    public DbSet<AcademyDZ.Models.Direction> Directions { get; set; } = default!;
    public DbSet<AcademyDZ.Models.Group> Groups { get; set; } = default!;
    public DbSet<AcademyDZ.Models.Student> Students { get; set; } = default!;
    public DbSet<AcademyDZ.Models.Teacher> Teachers { get; set; } = default!;
}
