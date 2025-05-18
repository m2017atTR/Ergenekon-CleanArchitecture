var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Ergenekon_UI_MVC>("ergenekon-ui-mvc");

builder.Build().Run();
