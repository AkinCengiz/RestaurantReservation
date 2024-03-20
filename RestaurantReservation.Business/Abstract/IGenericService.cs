using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Entities.Abstract;

namespace RestaurantReservation.Business.Abstract;
public interface IGenericService<T> where T : class,IEntity,new()
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    List<T> GetAll();
    List<T> GetListUnConditional();
    T Get(int id);
}
