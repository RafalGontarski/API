using API.Database.EntityFramework.Domain;
using API.Services.Abstractions.Interfaces;
using API.Services.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;




// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "You api title", Version = "v1" });
    c.AddSecurityDefinition("Bearer",
        new OpenApiSecurityScheme()
        {
            In = ParameterLocation.Header,
            Description = "Please enter into field the word 'Bearer' following by space and JWT",
            Name = "Authorization",
            Type = SecuritySchemeType.Http
        });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header,

            },
            new List<string>()
        }
    });
});


// IoC dependency resolve register
builder.Services.AddDbContext<AppDbContext>(
    db => db.UseSqlServer(builder.Configuration.GetConnectionString("MainApp")), ServiceLifetime.Singleton);

builder.Services.AddAuthentication("Bearer").AddJwtBearer();

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();



var app = builder.Build();

// Configure CORS
app.UseCors(options =>
{
    options.AllowCredentials();
    options.WithOrigins("http://localhost:3000"); // Allowed origins
    options.AllowAnyHeader(); // Allowed headers
    options.AllowAnyMethod(); // Allowed methods
    options.SetPreflightMaxAge(TimeSpan.FromSeconds(3600)); // Max age
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();