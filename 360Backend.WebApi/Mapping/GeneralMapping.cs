using _360Backend.DtoLayer.AboutDtos;
using _360Backend.DtoLayer.ContactDtos;
using _360Backend.DtoLayer.MainPageDtos;
using _360Backend.DtoLayer.ProjectDtos;
using _360Backend.DtoLayer.ReviewDtos;
using _360Backend.EntityLayer.Entities;
using AutoMapper;

namespace _360Backend.WebApi.Mapping;

public class GeneralMapping : Profile
{
    public GeneralMapping()
    {
        //AboutUs
        CreateMap<Aboutus,ResultAboutDto>().ReverseMap();
        CreateMap<Aboutus,CreateAboutDto>().ReverseMap();
        CreateMap<Aboutus,UpdateAboutDto>().ReverseMap();
        CreateMap<Aboutus,GetAboutDto>().ReverseMap();

        //Contact
        CreateMap<Contact,ResultContactDto>().ReverseMap();
        CreateMap<Contact,CreateContactDto>().ReverseMap();
        CreateMap<Contact,UpdateContactDto>().ReverseMap();
        CreateMap<Contact,GetContactDto>().ReverseMap();

        //MainPage
        CreateMap<MainPage,ResultMainPageDto>().ReverseMap();
        CreateMap<MainPage,CreateMainPageDto>().ReverseMap();
        CreateMap<MainPage,UpdateMainPageDto>().ReverseMap();
        CreateMap<MainPage,GetMainPageDto>().ReverseMap();

        //Project
        CreateMap<Project,ResultProjectDto>().ReverseMap();
        CreateMap<Project,CreateProjectDto>().ReverseMap();
        CreateMap<Project,UpdateProjectDto>().ReverseMap();
        CreateMap<Project,GetProjectDto>().ReverseMap();

        //Review
        CreateMap<Review,ResultReviewDto>().ReverseMap();
        CreateMap<Review,CreateReviewDto>().ReverseMap();
        CreateMap<Review,UpdateReviewDto>().ReverseMap();
        CreateMap<Review,GetReviewDto>().ReverseMap();

    }
    
}
