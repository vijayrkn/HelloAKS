using System.Runtime.InteropServices;

var app = WebApplication.Create(args);
app.MapGet("/", () => $"An API service written in {RuntimeInformation.FrameworkDescription} is running in {Environment.MachineName} using OS: {Environment.OSVersion}");
app.Run();