using MoneyLog.API.EndpointRegistrationExtensions;
using MoneyLog.API.StartupExtensions;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Services.RegisterConfiguration();

builder.Services.RegisterOptions(configuration);
builder.Services.RegisterRequestHandlers();
builder.Services.RegisterMongoDb();


var app = builder.Build();

// Endpoint Mapping
app.MapMoneyLogEndpoints();

if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

app.Run();