using AutoMapper;
using AutoMapperSample.DTO;
using AutoMapperSample.Entity;

namespace AutoMapperSample.AutoMapperProfile
{
    public class EmployeeProfile :Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployDTO>().ReverseMap();
        }
    }
}
