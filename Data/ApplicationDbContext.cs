using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UsandoAspNetCoreIdentity.Data.Identity;
using UsandoAspNetCoreIdentity.Models;

namespace UsandoAspNetCoreIdentity.Data;

public class ApplicationDbContext : IdentityDbContext<Usuario, Perfil, string>
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
}
