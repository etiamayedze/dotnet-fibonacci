using System;
using System.Diagnostics;
using System.IO;
using Fibonacci;
using Microsoft.Extensions.Configuration;

var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddEnvironmentVariables()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)  
    .AddJsonFile($"appsettings.{environmentName}.json", optional: true, reloadOnChange: true)
    .Build();

var applicationName = configuration.GetValue<string>("Application:Name");
var applicationMessage = configuration.GetValue<string>("Application:Message");

Console.WriteLine($"Application Name : {applicationName}");
Console.WriteLine($"Application Message : {applicationMessage}");

Stopwatch stopwatch = new();
stopwatch.Start();

using var fibonacciDataContext = new FibonacciDataContext();

var tasks = await new Fibonacci.Compute(fibonacciDataContext).ExecuteAsync(args);

foreach (var task in tasks) Console.WriteLine($"Fibo result: {task}");
stopwatch.Stop();
Console.WriteLine($"{stopwatch.Elapsed.Seconds} s");