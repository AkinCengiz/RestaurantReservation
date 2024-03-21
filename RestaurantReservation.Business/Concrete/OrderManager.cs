using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Business.Abstract;
using RestaurantReservation.DataAccess.Abstract;
using RestaurantReservation.Entities.Concrete;

namespace RestaurantReservation.Business.Concrete;
public class OrderManager : IOrderService
{
    private IOrderDal _orderDal;

    public OrderManager(IOrderDal orderDal)
    {
        _orderDal = orderDal;
    }

    public void Add(Order entity)
    {
        _orderDal.Add(entity);
    }

    public void Update(Order entity)
    {
        _orderDal.Update(entity);
    }

    public void Delete(Order entity)
    {
        _orderDal.Delete(entity);
    }

    public List<Order> GetAll()
    {
        return _orderDal.GetList(o => o.IsDeleted == false);
    }

    public List<Order> GetListUnConditional()
    {
        return _orderDal.GetList();
    }

    public Order Get(int id)
    {
        return _orderDal.Get(o => o.Id == id);
    }
}
