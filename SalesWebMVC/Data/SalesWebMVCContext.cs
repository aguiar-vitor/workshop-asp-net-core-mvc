using Microsoft.EntityFrameworkCore;

namespace SalesWebMVC.Data;

public class SalesWebMVCContext(DbContextOptions<SalesWebMVCContext> options) : DbContext(options)
{
    public DbSet<SalesWebMVC.Models.Department> Department { get; set; } = default!;
}
