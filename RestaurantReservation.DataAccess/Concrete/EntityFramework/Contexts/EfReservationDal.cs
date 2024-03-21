using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.DataAccess.Abstract;
using RestaurantReservation.Entities.Concrete;

namespace RestaurantReservation.DataAccess.Concrete.EntityFramework.Contexts;
public class EfReservationDal : EfEntityRepositoryBase<Reservation,RestaurantReservationContext>,IReservationDal
{
}
