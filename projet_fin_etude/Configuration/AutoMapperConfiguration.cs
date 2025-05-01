using AutoMapper;
using projet_fin_etude.Data;
using projet_fin_etude.Models;

namespace projet_fin_etude.Configuration
{
    public class AutoMapperConfiguration:Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Employer, EmployerDTO>().ReverseMap();
            CreateMap<JobApplicant, JobApplicantDTO>().ReverseMap();
            CreateMap<Admin, AdminDTO>().ReverseMap();
            CreateMap<Admin, RegisterDTO>().ReverseMap();
            CreateMap<Employer, RegisterDTO>().ReverseMap();
            CreateMap<JobApplicant, RegisterDTO>().ReverseMap();

            //CreateMap<Teacher, TeacherDto>().ReverseMap();
        }
    }
}
