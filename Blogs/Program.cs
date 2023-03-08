using BaseModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repositories;
using Sevices;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Khai bao connection
var connection = builder.Configuration.GetConnectionString("BloggingDatabase");

builder.Services.AddDbContext<BlogContext>(options => options.UseSqlServer(connection));

// Dependency Injection
// AddScoped, AddTransient, AddSingleton
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(typeof(Mapper));
//builder.Services.AddScoped<IUserRepository, UserRepository>();
//builder.Services.AddTransient<BlogContext, BlogContext>();
//builder.Services.AddSingleton<>();


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
