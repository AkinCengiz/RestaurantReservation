using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.DataAccess.Abstract;
using RestaurantReservation.DataAccess.Concrete.EntityFramework.Contexts;
using RestaurantReservation.Entities.Concrete;

namespace RestaurantReservation.DataAccess.Concrete.EntityFramework;
public class EfMenuDal : EfEntityRepositoryBase<Menu,RestaurantReservationContext>,IMenuDal
{
}
