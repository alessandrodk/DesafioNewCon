using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Dtos;
using Users.Models;

namespace Users.Profiles
{
    public class UsuarioProfile:Profile
    {

        public UsuarioProfile()
        {
            CreateMap<UsuarioDto,Usuario >();
            CreateMap<Usuario, IdentityUser<int>>();
        }
    }
}
