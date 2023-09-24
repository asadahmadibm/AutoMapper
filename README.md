# AutoMapper

1- Install-Package AutoMapper
2- in nuget pachage

automapper.extensions.microsoft.dependencyinjection

in service : 

in .net 5  or lower : services.AddAutoMapper(typeof(Startup));

in .net 6             builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


in new class :

public class CategoryProfile: Profile {

    public CategoryProfile() {
    
        CreateMap<Employee, EmployDTO>().ReverseMap();
        CreateMap<CategoryDto, Category>().ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Name)).ForMember(dest => dest.CategoryId, opt => opt.Ignore());
        CreateMap<Category, CategoryDto>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CategoryName));
        
    }
}

in class

    private readonly IMapper _mapper;
  
    public WeatherForecastController(IMapper mapper)
        {
            _mapper = mapper;
        }
        
    var result = _mapper.Map<DTO>(Entiry);
