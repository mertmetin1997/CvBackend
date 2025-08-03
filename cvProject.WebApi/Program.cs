using Autofac;
using Autofac.Extensions.DependencyInjection;
using cvProject.Business.Dependency_Resolvers.AutoFac;
using cvProject.Business.Mappers.AutoMapper;
using cvProject.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(option =>
{
    option.AddPolicy("AllowAllOrigins", builder => 
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddControllers();
builder.Services.AddDbContext<CvDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("MertMetinDb"),option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(CvDbContext))!.GetName().Name);
    });
});

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(
        builder => 
        {
            builder.RegisterModule(new AutoFacBusinessModule());
        
        }
    );
builder.Services.AddAutoMapper(typeof(MapProfile).Assembly);


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

app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
