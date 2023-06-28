using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using VitoriaMariaStudio.Application.Contracts.Categories;
using VitoriaMariaStudio.Application.Contracts.Jobs;
using VitoriaMariaStudio.Application.Contracts.Persons;
using VitoriaMariaStudio.Application.Contracts.Professionals;
using VitoriaMariaStudio.Application.Contracts.Roles;
using VitoriaMariaStudio.Application.Contracts.Schedulings;
using VitoriaMariaStudio.Application.Services.Categories;
using VitoriaMariaStudio.Application.Services.Jobs;
using VitoriaMariaStudio.Application.Services.Persons;
using VitoriaMariaStudio.Application.Services.Professionals;
using VitoriaMariaStudio.Application.Services.Roles;
using VitoriaMariaStudio.Application.Services.Schedulings;
using VitoriaMariaStudio.Repository.Context;
using VitoriaMariaStudio.Repository.Contracts;
using VitoriaMariaStudio.Repository.Repositories;
using VitoriaMariaStudio.Repository.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StudioDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IGenericRepository, GenericRepository>();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProfessionalsService, ProfessionalService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<ISchedulingService, SchedulingService>();
builder.Services.AddScoped<IJobService, JobService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<StudioDbContext>();

    dbContext.Database.Migrate();

    var seeder = new DbSeeder();
    DbSeeder.Seed(dbContext);
}

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