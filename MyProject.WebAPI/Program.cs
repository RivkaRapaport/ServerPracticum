//using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using MyProject.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyProject.MyContext;
//using MyProject.WebAPI.Middlewares;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<IContex, MyDBContext>();
builder.Services.AddServices();
//builder.Services.AddAutoMapper(typeof(Mapping));    

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddAuthorization();
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(name: "myOrigin", policy =>
//    {
//        policy.WithOrigins("*");
//    });

//});
builder.Services.AddCors(option => option.AddPolicy("corsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

var app = builder.Build();
app.UseCors("corsPolicy");


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//app.UseTrak();
//app.UseShabbat();

app.MapControllers();

app.Run();
