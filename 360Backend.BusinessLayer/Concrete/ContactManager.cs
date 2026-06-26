using _360Backend.BusinessLayer.Abstract;
using _360Backend.DataAccesLayer.Abstract;
using _360Backend.EntityLayer.Entities;

namespace _360Backend.BusinessLayer.Concrete;

public class ContactManager : IContactService
{
    private readonly IContactDal _contactDal;

    public ContactManager(IContactDal contactDal)
    {
        _contactDal = contactDal;
    }

    public List<Contact> GetAllList()
    {
        return _contactDal.GetAll();
    }

    public Contact GetById(int Id)
    {
        return _contactDal.GetById(Id);
    }

    public void Tadd(Contact entity)
    {
        _contactDal.Add(entity);
    }

    public void TDelete(Contact entity)
    {
       _contactDal.Delete(entity);
    }

    public void TUpdate(Contact entity)
    {
        _contactDal.Update(entity);
    }
}
