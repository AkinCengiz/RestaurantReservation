using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Business.Abstract;
using RestaurantReservation.DataAccess.Abstract;
using RestaurantReservation.Entities.Concrete;

namespace RestaurantReservation.Business.Concrete;
public class ReservationManager : IReservationService
{
    private IReservationDal _reservationDal;

    public ReservationManager(IReservationDal reservationDal)
    {
        _reservationDal = reservationDal;
    }

    public void Add(Reservation entity)
    {
        _reservationDal.Add(entity);
    }

    public void Update(Reservation entity)
    {
        _reservationDal.Update(entity);
    }

    public void Delete(Reservation entity)
    {
        _reservationDal.Delete(entity);
    }

    public List<Reservation> GetAll()
    {
        return _reservationDal.GetList(r => r.IsDeleted == false);
    }

    public List<Reservation> GetListUnConditional()
    {
        return _reservationDal.GetList();
    }

    public Reservation Get(int id)
    {
        return _reservationDal.Get(r => r.Id == id);
    }
}
