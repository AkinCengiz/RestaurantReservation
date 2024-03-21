using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Entities.Abstract;

namespace RestaurantReservation.Entities.Concrete;
public class Table : BaseEntity
{
    public string Name { get; set; }
    public int Capacity { get; set; }
}
