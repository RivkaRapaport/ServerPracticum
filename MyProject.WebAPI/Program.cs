using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using MyProject.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyProject.MyContext;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<IContex, MyDBContext>();
builder.Services.AddServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddAuthorization();
builder.Services.AddCors(option => option.AddPolicy("corsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

var app = builder.Build();
app.UseCors("corsPolicy");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
