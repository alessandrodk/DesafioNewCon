using AutoMapper;
using Business.Interface;
using Business.Interface.IRepository;
using Business.Interface.IServices;

using Business.Services;
using DataAccess.Repository;
using DataAcess.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Ajuda.Mais.DI
{
    public class DependenceInjection
    {

        public DependenceInjection(WebApplicationBuilder builder)
        {
            
            builder.Services.AddDbContext<AplicationDbContext>(options =>
            options.UseSqlServer(
                builder.Configuration.GetConnectionString("SQLSERVER")
                                        ));

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddScoped<IPontoTuristicoRepository, PontoTuristicoRepository>();
            builder.Services.AddScoped<IPontoTuristicoService, PontoTuristicoService>();
        }
    }
}
