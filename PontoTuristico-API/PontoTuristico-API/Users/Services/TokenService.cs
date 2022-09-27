using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Users.Models;

namespace Users.Services
{
    public class TokenService
    {

        public Token CreateToken(IdentityUser<int> usuario)
        {

            //definindo os direitos do usuário
            Claim[] direitosUsuario = new Claim[]
            {
                new Claim("username", usuario.UserName),
                new Claim("id", usuario.Id.ToString())
            };

            //definindo a chave
            var chaveAleatoria = Guid.NewGuid();

            var chave = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(chaveAleatoria.ToString())
                );

            //verificando as credenciais
            var credenciais = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

            //configurando o token
            var token = new JwtSecurityToken(
                claims: direitosUsuario,
                signingCredentials: credenciais,
                expires: DateTime.UtcNow.AddHours(1)
                );

            //transformando o token em uma string para passar par  o model
            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);


            //retonando nosso token
            return new Token(tokenString);

        }
    }
}

