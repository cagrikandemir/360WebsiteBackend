using _360Backend.DataAccesLayer.Abstract;
using _360Backend.DataAccesLayer.Concrete;
using _360Backend.DataAccesLayer.Repositories;
using _360Backend.EntityLayer.Entities;

namespace _360Backend.DataAccesLayer.EntityFramework;

public class EfProjectDal : GenericRepository<Project>, IProjectDal
{
    public EfProjectDal(_360BackendContext context) : base(context)
    {
    }
}
