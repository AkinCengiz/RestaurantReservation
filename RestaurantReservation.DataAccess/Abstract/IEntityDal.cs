using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Entities.Abstract;

namespace RestaurantReservation.DataAccess.Abstract;
public interface IEntityDal<T> where T : class,IEntity,new()
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    List<T> GetList(Expression<Func<T,bool>> filter = null);
    T Get(Expression<Func<T, bool>> filter);
}
