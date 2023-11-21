using TodoApi.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("SqliteConnectionString") ?? "Data Source=app.db;Cache=Shared";

builder.Services.AddSqlite<AppDbContext>(connectionString);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
