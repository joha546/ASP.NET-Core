// Creating the Web Host and Services
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

// Building the application
var app = builder.Build();

// ConfigurationManager configuration = builder.Configuration;

//Configuring New Inline Middleware Component using Run Extension Method
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Getting Response from First Middleware");


// Running the application
app.Run();
