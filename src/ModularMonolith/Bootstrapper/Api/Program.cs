using Carter;
using Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddCarterWithAssemblies(typeof(CatalogModule).Assembly);

builder.Services
    .AddCatalogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddOrderModule(builder.Configuration);

var app = builder.Build();

app.MapCarter();

app.UseCatalogModule()
   .UseBasketModule()
   .UseOrderModule();

app.Run();
