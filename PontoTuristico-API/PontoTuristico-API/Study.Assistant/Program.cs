

using Ajuda.Mais.DI;
using DataAcess.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.


builder.Services.AddCors(opt =>
    opt.AddPolicy("Production", 
        options => 
            options
            .AllowAnyOrigin() 
            .AllowAnyMethod()
            .AllowAnyHeader()
           
)); 


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



new DependenceInjection(builder);

builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseCors("Production");

    app.UseSwagger();
    app.UseSwaggerUI();
//}


app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.UseRouting();
app.Run();
