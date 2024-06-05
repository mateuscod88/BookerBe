using Booker.API.Extensions;
using Booker.Application.Shared.Abstraction;
using Booker.Infrastructure;
using NLog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
LogManager.Setup(setupBuilder =>
{
    setupBuilder.LoadConfigurationFromFile(
    string.Concat(Directory.GetCurrentDirectory(),
        "/nlog.config"));
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureCors();
builder.Services.AddInfrastructure();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();
var logger = app.Services.GetRequiredService<ILogingManager>();
app.ConfigureExceptionHandler(logger);

// app.Map("/mateo", builder =>
// {
//     builder.Use(async (context, next) =>
//     {
//         await context.Response.WriteAsync("mateo");
//         await next.Invoke();
//     });
// });
// app.Use(async (context, next) =>
// {
//     Console.WriteLine("Przed");
//     context.Response.StatusCode = 200; 
//
//     await context.Response.WriteAsync("siema");
//
//     await next.Invoke();
//     Console.WriteLine("Po");
// });

// app.Run( async context =>
// {
//     Console.WriteLine("run");
// });
app.MapControllers();

app.Run();