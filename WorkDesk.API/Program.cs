var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<WorkDesk.API.Services.EmployeeService>();

var app = builder.Build();

app.MapControllers();

app.Run();