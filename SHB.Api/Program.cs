using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SHB.Application.Contract;
using SHB.Application.implementations;
using SHB.Application.IRepositories;
using SHB.Application.Mapper;
using SHB.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddControllers();


builder.Services.AddHttpContextAccessor();

//Service
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IFacultyService, FacultyService>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IFieldOfStudyService, FieldOfStudyService>();
builder.Services.AddScoped<IProgramService, ProgramService>();

//Repository
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IFacultyRepository, FacultyRepository>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IFieldOfStudyRepository, FieldOfStudyRepository>();
builder.Services.AddScoped<IProgramRepository, ProgramRepository>();

var configuration = new MapperConfiguration(cfg => { ModelMapper.MappingDto(cfg); });
IMapper mapper = configuration.CreateMapper();
builder.Services.AddSingleton(mapper);

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
