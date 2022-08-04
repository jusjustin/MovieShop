using ApplicationCore.RepositoryContracts;
using ApplicationCore.ServicesContacts;
using ApplicationCore.Entities;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using MovieShopAPI.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependency Injection
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();

builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddScoped<IGenreService, GenreService>();

builder.Services.AddScoped<ICastService, CastService>();
builder.Services.AddScoped<ICastRepository, CastRepository>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAccountService, AccountService>();

// read the connection string from appsettings.json and inject connection string in to DbContext
builder.Services.AddDbContext<MovieShopDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieShopDbConnection"));
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = false,
            ValidateIssuer = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["secretKey"]))
        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMovieShopExceptionMiddleware();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
