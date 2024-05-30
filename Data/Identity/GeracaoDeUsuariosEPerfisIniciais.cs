using Microsoft.AspNetCore.Identity;

namespace UsandoAspNetCoreIdentity.Data.Identity
{
    public class GeracaoDeUsuariosEPerfisIniciais
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly RoleManager<Perfil> _roleManager;

        public GeracaoDeUsuariosEPerfisIniciais(RoleManager<Perfil> roleManager, UserManager<Usuario> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public void GerarPerfis()
        {
            if (!_roleManager.RoleExistsAsync("Atendente").Result)
            {
                Perfil perfil = new();
                perfil.Name = "Atendente";
                perfil.NormalizedName = perfil.Name.ToUpper();
                IdentityResult roleResult = _roleManager.CreateAsync(perfil).Result;
            }

            if (!_roleManager.RoleExistsAsync("Administrador").Result)
            {
                Perfil perfil = new();
                perfil.Name = "Administrador";
                perfil.NormalizedName = perfil.Name.ToUpper();
                IdentityResult roleResult = _roleManager.CreateAsync(perfil).Result;
            }

        }


        public void GerarUsuarios()
        {
            if (_userManager.FindByNameAsync("admin").Result == null)
            {
                Usuario usuario = new();
                usuario.UserName = "admin";
                usuario.NormalizedUserName = usuario.UserName.ToUpper();
                usuario.LockoutEnabled = false;
                usuario.SecurityStamp = Guid.NewGuid().ToString();
                usuario.NomeCompleto = "Administrador do sistema";
                usuario.Ativo = true;

                IdentityResult result = _userManager.CreateAsync(usuario, "#Adm$2024").Result;

                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(usuario, "Administrador").Wait();
                }
            }


        }
    }
}
