using Microsoft.EntityFrameworkCore;
using Roomie_API.Contexto;
using Roomie_API.Interfaces.Repositories;
using Roomie_API.Interfaces.Services;
using Roomie_API.Repositories;
using Roomie_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var sqlServerConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<RoomieContext>(options =>
    options.UseSqlServer(sqlServerConnection));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IQuartoRepository, QuartoRepository>();
builder.Services.AddScoped<IReservaRepository, ReservaRepository>();
builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<IFotoRepository, FotoRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IQuartoService, QuartoService>();
builder.Services.AddScoped<IReservaService, ReservaService>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IFotoService, FotoService>();

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
