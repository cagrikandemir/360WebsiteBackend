using _360Backend.BusinessLayer.Abstract;
using _360Backend.DataAccesLayer.Abstract;
using _360Backend.EntityLayer.Entities;

namespace _360Backend.BusinessLayer.Concrete;

public class MainPageManager : IMainPageService
{
    private readonly IMainPageDal _mainPageDal;

    public MainPageManager(IMainPageDal mainPageDal)
    {
        _mainPageDal = mainPageDal;
    }

    public List<MainPage> GetAllList()
    {
        return _mainPageDal.GetAll();
    }

    public MainPage GetById(int Id)
    {
        return _mainPageDal.GetById(Id);
    }

    public void Tadd(MainPage entity)
    {
        _mainPageDal.Add(entity);
    }

    public void TDelete(MainPage entity)
    {
        _mainPageDal.Delete(entity);
    }

    public void TUpdate(MainPage entity)
    {
        _mainPageDal.Update(entity);
    }
}
