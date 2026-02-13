var builder = DistributedApplication.CreateBuilder(args);

// Voeg API project toe
var api = builder.AddProject<Projects.MyApp_Api>("api");

// Voeg Web project toe en koppel aan API
builder.AddProject<Projects.MyApp_Web>("web")
       .WithReference(api);

// Build en run
builder.Build().Run();
