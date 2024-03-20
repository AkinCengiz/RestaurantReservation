using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Entities.Abstract;

namespace RestaurantReservation.Entities.Concrete;
public class Menu : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}
