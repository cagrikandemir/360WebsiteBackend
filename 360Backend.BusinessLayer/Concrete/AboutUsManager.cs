using _360Backend.BusinessLayer.Abstract;
using _360Backend.DataAccesLayer.Abstract;
using _360Backend.EntityLayer.Entities;

namespace _360Backend.BusinessLayer.Concrete;

public class AboutUsManager : IAboutUsService
{
    private readonly IAboutDal _aboutdal;

    public AboutUsManager(IAboutDal aboutdal)
    {
        _aboutdal = aboutdal;
    }

    public List<Aboutus> GetAllList()
    {
        return _aboutdal.GetAll();
    }

    public Aboutus GetById(int Id)
    {
        return _aboutdal.GetById(Id);
    }

    public void Tadd(Aboutus entity)
    {
        _aboutdal.Add(entity);
    }

    public void TDelete(Aboutus entity)
    {
        _aboutdal.Delete(entity);
    }

    public void TUpdate(Aboutus entity)
    {
        _aboutdal.Update(entity);
    }
}
