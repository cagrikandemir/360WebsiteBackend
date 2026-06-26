namespace _360Backend.BusinessLayer.Abstract;

public interface IGenericService<T> where T : class
{
    void Tadd(T entity);
    void TDelete(T entity);
    void TUpdate(T entity);
     List<T>GetAllList();
    T GetById(int Id);
}
