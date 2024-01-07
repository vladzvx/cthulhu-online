using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();

services.AddSwaggerGen().AddSwaggerGenNewtonsoftSupport();
services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseSwagger();
app.UseRouting();
app.UseSwaggerUI(c =>
{
    c.ShowCommonExtensions();
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cthulhu");
});

app.MapControllers();
app.UseCors(p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().SetPreflightMaxAge(TimeSpan.FromSeconds(60)));
app.Run();
