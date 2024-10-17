var builder = DistributedApplication.CreateBuilder(args);
var sql = builder
    .AddSqlServer("theServer")
    .AddDatabase("BlogDb");
builder.AddProject<Projects.Blogs>("blogs");

builder.Build().Run();
