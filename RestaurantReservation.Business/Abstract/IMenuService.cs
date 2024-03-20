using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Entities.Concrete;

namespace RestaurantReservation.Business.Abstract;
public interface IMenuService : IGenericService<Menu>
{
    List<Menu> GetListPriceRange(decimal minPrice, decimal maxPrice);
    List<Menu> GetListIsActive();
    List<Menu> GetListIsDeactive();
}
