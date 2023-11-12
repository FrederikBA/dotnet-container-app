var policyName = "AllowOrigin";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policyName,
        builder =>
        {
            builder
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});

var app = builder.Build();
app.MapGet("/", () => "Hello World! I am now changed!");

app.UseCors(policyName);


app.Run();