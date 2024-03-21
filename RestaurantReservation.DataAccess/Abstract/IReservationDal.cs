using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Entities.Concrete;

namespace RestaurantReservation.DataAccess.Abstract;
public interface IReservationDal : IEntityDal<Reservation>
{
}
