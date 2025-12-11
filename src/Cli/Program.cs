
using Microsoft.Extensions.Hosting;
using RazorConsole.Core;
using Todo.Cli.Components;

var builder = Host.CreateDefaultBuilder(args);

builder.UseRazorConsole<Counter>();

var host = builder.Build();
await host.RunAsync();
