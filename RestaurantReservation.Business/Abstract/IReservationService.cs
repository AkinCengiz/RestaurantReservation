using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Entities.Concrete;

namespace RestaurantReservation.Business.Abstract;
public interface IReservationService : IGenericService<Reservation>
{
    List<Reservation> GetListByIsActive();
    List<Reservation> GetListByInActive();
    List<Customer> GetListByCustomer();
    List<Table> GetListByTable();
}
