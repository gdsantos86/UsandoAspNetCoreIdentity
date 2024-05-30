using Microsoft.EntityFrameworkCore;
using UsandoAspNetCoreIdentity.Models;

namespace UsandoAspNetCoreIdentity.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
}
