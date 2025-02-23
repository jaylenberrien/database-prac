var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
    options.AddPolicy(name: MyAllowSpecificOrigins,
    policy =>
    {
        policy.WithOrigins("http://127.0.0.1:5500");
    })
);

var app = builder.Build();
app.MapGet("/", () => "Hello World!");

app.UseCors(MyAllowSpecificOrigins);

app.Run("http://localhost:3000");
