// Creating the Web Host and Services
var builder = WebApplication.CreateBuilder(args);

// Building the application
var app = builder.Build();

// Setting up the endpoints, Routing, Middleware Components
app.MapGet("/", () => System.Diagnostics.Process.GetCurrentProcess().ProcessName);

// Running the application
app.Run();
