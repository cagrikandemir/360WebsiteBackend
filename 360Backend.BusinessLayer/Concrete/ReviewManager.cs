using _360Backend.BusinessLayer.Abstract;
using _360Backend.DataAccesLayer.Abstract;
using _360Backend.EntityLayer.Entities;

namespace _360Backend.BusinessLayer.Concrete;

public class ReviewManager : IReviewService
{
    private readonly IReviewDal _reviewDal;

    public ReviewManager(IReviewDal reviewDal)
    {
        _reviewDal = reviewDal;
    }

    public List<Review> GetAllList()
    {
        return _reviewDal.GetAll();
    }

    public Review GetById(int Id)
    {
        return _reviewDal.GetById(Id);
    }

    public void Tadd(Review entity)
    {
        _reviewDal.Add(entity);
    }

    public void TDelete(Review entity)
    {
        _reviewDal.Delete(entity);
    }

    public void TUpdate(Review entity)
    {
        _reviewDal.Update(entity);
    }
}
