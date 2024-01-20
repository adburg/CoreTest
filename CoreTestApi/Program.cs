using Microsoft.OpenApi.Models;

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
