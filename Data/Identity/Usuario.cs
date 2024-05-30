using Microsoft.AspNetCore.Identity;

namespace UsandoAspNetCoreIdentity.Data.Identity
{
    public class Usuario : IdentityUser
    {
        public string NomeCompleto { get; set; }
        public bool Ativo { get; set; }
    }
}
