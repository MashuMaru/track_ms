using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tracker.Data;
using Tracker.Services;
using Tracker.Services.Services;
using Tracker.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/*Services*/
// var mapperConfig = new MapperConfiguration(mc => 
// {
//     mc.AddProfile(new MappingProfiler());
// });

builder.Services.AddSingleton(
    new MapperConfiguration(mc => 
    { 
        mc.AddProfile(new MappingProfiler()); 
    }).CreateMapper());

builder.Services.AddScoped<IUserService, UserService>();


/*DbContext*/
builder.Services.AddDbContext<TrackerContext>(options => 
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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
