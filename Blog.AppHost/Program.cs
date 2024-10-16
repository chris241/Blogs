var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Blogs>("blogs");

builder.Build().Run();
