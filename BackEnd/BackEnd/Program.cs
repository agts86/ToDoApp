using Microsoft.EntityFrameworkCore;
using BackEnd.DataBase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// appsettingsの設定
IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables()
    .Build();
    
// DockerコンテナのときのDB接続文字列
var defaultConnection = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");

// EFCoreの設定
builder.Services.AddDbContext<ToDoAppContext>
(
    options => options.UseSqlServer(defaultConnection ?? config.GetValue<string>("connectionString"))
);

// SPAの設定
builder.Services.AddSpaStaticFiles(configuration => { configuration.RootPath = "dist"; });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseSpa(spa => {});
app.Run();
