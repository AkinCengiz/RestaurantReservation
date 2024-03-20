using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Business.Abstract;
using RestaurantReservation.DataAccess.Abstract;
using RestaurantReservation.Entities.Concrete;

namespace RestaurantReservation.Business.Concrete;
public class CustomerManager : ICustomerService
{
    private ICustomerDal _customerDal;

    public CustomerManager(ICustomerDal customerDal)
    {
        _customerDal = customerDal;
    }

    public void Add(Customer entity)
    {
        _customerDal.Add(entity);
    }

    public void Update(Customer entity)
    {
        _customerDal.Update(entity);
    }

    public void Delete(Customer entity)
    {
        entity.IsDeleted = true;
        _customerDal.Update(entity);
    }

    public List<Customer> GetAll()
    {
        return _customerDal.GetList(c => c.IsDeleted == false);
    }

    public List<Customer> GetListUnConditional()
    {
        return _customerDal.GetList();
    }

    public Customer Get(int id)
    {
        return _customerDal.Get(c => c.Id == id);
    }

    public List<Customer> GetByIsActive()
    {
        return _customerDal.GetList(c => c.IsActive == true && c.IsDeleted == false);
    }

    public List<Customer> GetByIsDeactive()
    {
        return _customerDal.GetList(c => c.IsActive == false && c.IsDeleted == false);
    }
}
