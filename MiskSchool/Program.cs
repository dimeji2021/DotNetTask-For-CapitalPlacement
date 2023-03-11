using InterviewTask.Infrastructure.Repository;
using MiskSchool.Infrastructure.IRepositories;
using MiskSchool.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IApplicationFormRepository, ApplicationFormRepository>();
builder.Services.AddScoped<IDetailRepository, DetailRepository>();
builder.Services.AddScoped<IWorkFlowRepository, WorkFlowRepository>();
builder.Services.AddAutoMapper(typeof(Mapping));




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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
