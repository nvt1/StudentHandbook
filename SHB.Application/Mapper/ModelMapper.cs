using AutoMapper;
using SHB.Application.Models.Reponse;
using SHB.Application.Models.Request.Course;
using SHB.Application.Models.Request.Faculty;
using SHB.Application.Models.Request.FieldOfStudy;
using SHB.Application.Models.Request.Program;
using SHB.Application.Models.Request.User;
using SHB.Domain;

namespace SHB.Application.Mapper
{
    public static class ModelMapper
    {
        public static void MappingDto(IMapperConfigurationExpression cfg)
        {
            //Response
            cfg.CreateMap<User, UserDto>();
            cfg.CreateMap<Program, ProgramDto>();
            cfg.CreateMap<Faculty, FacultyDto>();
            cfg.CreateMap<FieldOfStudy, FieldOfStudyDto>();
            cfg.CreateMap<Course, CourseDto>();

            //Request
            cfg.CreateMap<Course, CreateCourseRequest>().ReverseMap();
            cfg.CreateMap<Faculty, CreateFacultyRequest>().ReverseMap();
            cfg.CreateMap<FieldOfStudy, CreateFieldOfStudyRequest>().ReverseMap();
            cfg.CreateMap<Program, CreateProgramRequest>().ReverseMap();
            cfg.CreateMap<User, CreateUserRequest>().ReverseMap();
        }
    }
}
