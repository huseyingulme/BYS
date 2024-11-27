using Microsoft.EntityFrameworkCore;
using UniversitySystem.Data;
using UniversitySystem.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<StudentService>();

var app = builder.Build();

app.MapControllers();

app.Run();
