﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Entities.Abstract;

namespace RestaurantReservation.Entities.Concrete;
public class Order : BaseEntity
{
    public int ReservationId { get; set; }
    public Reservation Reservation { get; set; }
    public int MenuId { get; set; }
    public Menu Menu { get; set; }
    public DateTime OrderDate { get; set; }
    public int Quantity { get; set; }
}
