using AutoMapper;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.DTO.Categories;
using VitoriaMariaStudio.DTO.Jobs;
using VitoriaMariaStudio.DTO.Persons;
using VitoriaMariaStudio.DTO.Professionals;
using VitoriaMariaStudio.DTO.Roles;
using VitoriaMariaStudio.DTO.Schedulings;

namespace VitoriaMariaStudio.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Job, JobDto>();
            CreateMap<JobDto, Job>();
            CreateMap<Person, PersonDto>();
            CreateMap<PersonDto, Person>();
            CreateMap<Professional, ProfessionalDto>();
            CreateMap<ProfessionalDto, Professional>();
            CreateMap<Role, RoleDto>();
            CreateMap<RoleDto, Role>();
            CreateMap<Scheduling, SchedulingDto>();
            CreateMap<SchedulingDto, Scheduling>();
        }
    }
}