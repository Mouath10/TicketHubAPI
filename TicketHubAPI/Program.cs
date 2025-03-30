using Microsoft.EntityFrameworkCore;
using TicketHubAPI.Data;
using TicketHubAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure the database connection to SQL Server using the connection string from appsettings.json
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddSingleton<QueueService>(); // Register your QueueService

var app = builder.Build();

// Use routing and authorization
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
