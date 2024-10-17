using Blogs.Database;
using Blogs.Extension;
using Blogs.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBlogReposiroty, BlogRepository>();
builder.Services.AddComponent();
var connectionString = builder.Configuration.GetConnectionString("PostgresDatabase");
builder.Services.AddDbContext<BlogContext>(options =>
    options.UseNpgsql(connectionString));
//builder.AddSqlServerDbContext<BlogContext>("BlogDb");

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
