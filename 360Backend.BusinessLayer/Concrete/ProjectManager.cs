using _360Backend.BusinessLayer.Abstract;
using _360Backend.DataAccesLayer.Abstract;
using _360Backend.EntityLayer.Entities;

namespace _360Backend.BusinessLayer.Concrete;

public class ProjectManager : IProjectService
{
    private readonly IProjectDal _projectDal;

    public ProjectManager(IProjectDal projectDal)
    {
        _projectDal = projectDal;
    }

    public List<Project> GetAllList()
    {
        return _projectDal.GetAll();
    }

    public Project GetById(int Id)
    {
        return _projectDal.GetById(Id);
    }

    public void Tadd(Project entity)
    {
        _projectDal.Add(entity);
    }

    public void TDelete(Project entity)
    {
        _projectDal.Delete(entity);
    }

    public void TUpdate(Project entity)
    {
        _projectDal.Update(entity);
    }
}
