using TodoApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("SqliteConnectionString") ?? "Data Source=app.db;Cache=Shared";

builder.Services.AddSqlite<AppDbContext>(connectionString);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();
