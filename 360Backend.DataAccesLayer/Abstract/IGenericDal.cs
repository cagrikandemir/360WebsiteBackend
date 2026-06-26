namespace _360Backend.DataAccesLayer.Abstract;

public interface IGenericDal<T>where T : class
{
    void Add (T entity);
    void Delete (T entity);
    void Update (T entity);
    List<T> GetAll();
    T GetById(int id);
}
