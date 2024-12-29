using AirlineCoreLibrary.Utility;
using AirlinesEventPublisher;

var builder = Host.CreateApplicationBuilder(args);

// Register the Core Library services
builder.Services.RegisterAppServices();

builder.Services.AddHostedService<Worker>();

var host = builder.Build();

host.Run();