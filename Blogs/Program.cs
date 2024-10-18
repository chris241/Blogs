using Blogs.Database;
using Blogs.Extension;
using Blogs.Repositories;
using Microsoft.EntityFrameworkCore;
using Serilog;

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(configuration)
    .Enrich.FromLogContext()
    .WriteTo.Seq("http://blog-seq:5341")
    .CreateBootstrapLogger();
try
{
    Log.Information("Starting server."); 

    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddScoped<IBlogReposiroty, BlogRepository>();
    builder.Services.AddComponent();
    var connectionString = builder.Configuration.GetConnectionString("PostgresDatabase");
    builder.Services.AddDbContext<BlogContext>(options =>
        options.UseNpgsql(connectionString));


    var app = builder.Build();

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
}
catch (Exception ex)
{
    Log.Fatal(ex, "Server terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}

