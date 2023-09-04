// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ConsoleDI.Example;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<IExampleTransientService, ExampleTransientService>();
builder.Services.AddTransient<IExampleTransientService, ExampleTransientService>();