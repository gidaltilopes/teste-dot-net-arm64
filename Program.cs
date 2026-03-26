var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World ARM64");

app.Run("http://0.0.0.0:80");