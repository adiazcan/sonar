var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.sonar_ApiService>("apiservice");

builder.AddProject<Projects.sonar_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();
