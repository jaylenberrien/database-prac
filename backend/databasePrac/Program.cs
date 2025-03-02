using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
    options.AddPolicy(name: MyAllowSpecificOrigins,
    policy =>
    {
        policy.WithOrigins("http://127.0.0.1:5500")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials();
    })
);

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors(MyAllowSpecificOrigins);

app.MapGet("/", () => "Hello World!");
app.MapControllers();


app.Run("http://localhost:3000");
