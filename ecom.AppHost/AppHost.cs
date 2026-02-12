var builder = DistributedApplication.CreateBuilder(args);
var catalogService = builder.AddProject<Projects.catalog_service>("catalog-service");
var orderingService = builder.AddProject<Projects.Ordering_Service>("ordering-service");
builder.AddProject<Projects.Gateway_API>("gateway-API")
    .WithReference(catalogService)
    .WithReference(orderingService);

builder.Build().Run();
