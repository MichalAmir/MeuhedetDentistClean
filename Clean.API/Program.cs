using Clean.Core.Repositories;
using Clean.Data;
using Clean.Data.Repository;
using Clean.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<clientsServices>();
builder.Services.AddScoped<IClientsRepository, clientsRepository>();
builder.Services.AddSingleton<DataContext>();

builder.Services.AddScoped<doctorsServices>();
builder.Services.AddScoped<IDoctorsRepository, doctorsRepository>();
builder.Services.AddSingleton<DataContext>();

builder.Services.AddScoped<turnsServices>();
builder.Services.AddScoped<ITurnsRepository, turnsRepository>();
builder.Services.AddSingleton<DataContext>();

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

app.Run();