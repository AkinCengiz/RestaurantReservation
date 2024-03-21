using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Entities.Abstract;

namespace RestaurantReservation.Entities.Concrete;
public class Reservation : BaseEntity
{
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public int TableId { get; set; }
    public Table Table { get; set; }
    public DateTime DateInfo { get; set; }
    public DateTime TimeInfo { get; set; }
}
