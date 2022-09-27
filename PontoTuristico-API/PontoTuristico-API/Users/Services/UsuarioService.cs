using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using Users.Dtos;
using Users.Models;
using System.Linq;
namespace Users.Services
{
    public class UsuarioService
    {
        private IMapper _mapper;
        //cadastrar usuario
        private UserManager<IdentityUser<int>> _userManager;

        private TokenService _tokenService;

        //logar e validar usuário
        private SignInManager<IdentityUser<int>> _signInManager;
        public UsuarioService(IMapper mapper, UserManager<IdentityUser<int>> userManager, SignInManager<IdentityUser<int>> signInManager, TokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public  Result LogarUsuario(Auth auth)
        {
        
            var resultadoIdentity = _signInManager.PasswordSignInAsync(auth.Usuario, auth.Senha, false,false);
            //var resultadoIdentityCopy = _signInManager.PasswordSignInAsync(auth.Usuario, auth.Senha, true);


            if (resultadoIdentity.Result.Succeeded)
            {
                var identityUser = _signInManager
                    .UserManager
                    .Users
                    .FirstOrDefault(usuario =>
                    usuario.NormalizedUserName == auth.Usuario.ToUpper());

                var token = _tokenService.CreateToken(identityUser);

                return Result.Ok().WithSuccess(token.Value);

            }
            var errors = resultadoIdentity.Result;
            return Result.Fail("Login falhou!");

        }
        public Result CadastrarUsuario(UsuarioDto usuarioDto)
        {
            var user = _mapper.Map<Usuario>(usuarioDto);

            IdentityUser<int> userIdentity = _mapper.Map<IdentityUser<int>>(user);

            var resultIdentity = _userManager.CreateAsync(userIdentity, usuarioDto.Password);

            if(resultIdentity.Result.Succeeded) return Result.Ok();

            return Result.Fail("Falha ao cadastrar usuário!");

        }
    }
}
