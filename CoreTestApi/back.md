# Backend
### Project setup
- dotnet new web -o CoreTestApi 
- cd CoreTestApi 
- code -r ../CoreTestApi 
- dotnet dev-certs https --trust
- dotnet add package Microsoft.EntityFrameworkCore.InMemory --prerelease 
- dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore --prerelease

### Swagger setup
- dotnet add package Microsoft.AspNetCore.Mvc.Versioning
- dotnet add package Swashbuckle.AspNetCore
- program.cs for minimal swagger
```c#
var builder = WebApplication.CreateBuilder(args);

//add services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "CoreTest API",
        Description = "An ASP.NET Project for testing APIs",
    });
});

var app = builder.Build();

//use swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapGet("/", () => "Hello World!");

app.Run();
```


