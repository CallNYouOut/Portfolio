using CGaffney206Lab5.Models;
using CGaffney206Lab5.Repositories;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using static System.Console;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSportsLeaguesContext();
builder.Services.AddControllers(options =>
{
    WriteLine("Default output formatters: ");
    foreach (IOutputFormatter formatter in options.OutputFormatters)
    {
        OutputFormatter? mediaformmatter = formatter as OutputFormatter;
        if (mediaformmatter == null)
        {
            WriteLine($" {formatter.GetType().Name}.");
        }
        else
        {
            WriteLine(" {0}, Media Types: {1}", arg0: mediaformmatter.GetType().Name, arg1: string.Join(", ", mediaformmatter.SupportedMediaTypes));
        }

    }
}).AddXmlDataContractSerializerFormatters().AddXmlSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Lab 5 Service Web API", Version = "v1" });
});
builder.Services.AddScoped<ISoccerPlayerRepository, SoccerPlayerRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Lab 5 Swagger Service API Version 1");
        c.SupportedSubmitMethods(new[] { SubmitMethod.Get, SubmitMethod.Post, SubmitMethod.Put, SubmitMethod.Delete });
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();
