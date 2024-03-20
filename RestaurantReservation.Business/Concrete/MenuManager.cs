using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Business.Abstract;
using RestaurantReservation.DataAccess.Abstract;
using RestaurantReservation.Entities.Concrete;

namespace RestaurantReservation.Business.Concrete;
public class MenuManager : IMenuService
{
    private IMenuDal _menuDal;

    public MenuManager(IMenuDal menuDal)
    {
        _menuDal = menuDal;
    }

    public void Add(Menu entity)
    {
        _menuDal.Add(entity);
    }

    public void Update(Menu entity)
    {
        _menuDal.Update(entity);
    }

    public void Delete(Menu entity)
    {
        entity.IsDeleted = true;
        _menuDal.Update(entity);
    }

    public List<Menu> GetAll()
    {
        return _menuDal.GetList(m => m.IsDeleted == false);
    }

    public List<Menu> GetListUnConditional()
    {
        return _menuDal.GetList();
    }

    public Menu Get(int id)
    {
        return _menuDal.Get(m => m.Id == id);
    }

    public List<Menu> GetListPriceRange(decimal minPrice, decimal maxPrice)
    {
        return _menuDal.GetList(m => m.Price >= minPrice && m.Price <= maxPrice);
    }

    public List<Menu> GetListIsActive()
    {
        return _menuDal.GetList(m => m.IsActive == true);
    }

    public List<Menu> GetListIsDeactive()
    {
        return _menuDal.GetList(m => m.IsActive == false);
    }
}
