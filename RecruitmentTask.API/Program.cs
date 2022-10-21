
using RecruitmentTask.API.Helpers;
using RecruitmentTask.Core.Interfaces;
using RecruitmentTask.Infrastructure;
using RecruitmentTask.Infrastructure.Repository;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(MappingProfiles));

#region Ioc
builder.Services.AddScoped<ISimpleApiContext, SimpleApiContext>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
#endregion



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(builder => builder.WithOrigins("http://localhost:4200")
               .AllowAnyMethod()
               .AllowAnyHeader());

app.MapControllers();
app.Run();
