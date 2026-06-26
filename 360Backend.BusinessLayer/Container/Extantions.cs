using _360Backend.BusinessLayer.Abstract;
using _360Backend.BusinessLayer.Concrete;
using _360Backend.DataAccesLayer.Abstract;
using _360Backend.DataAccesLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace _360Backend.BusinessLayer.Container;

public static class Extantions
{
    public static void ContainerDependencies(this IServiceCollection services)
    {
        services.AddScoped<IAboutUsService, AboutUsManager>();
        services.AddScoped<IAboutDal, EfAboutDal>();

        services.AddScoped<IContactService, ContactManager>();
        services.AddScoped<IContactDal, EfContactDal>();

        services.AddScoped<IProjectService, ProjectManager>();
        services.AddScoped<IProjectDal, EfProjectDal>();

        services.AddScoped<IProjectService, ProjectManager>();
        services.AddScoped<IProjectDal, EfProjectDal>();

        services.AddScoped<IReviewService, ReviewManager>();
        services.AddScoped<IReviewDal, EfReviewDal>();
    }
}
