﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Entities.Concrete;

namespace RestaurantReservation.Business.Abstract;
public interface ICustomerService : IGenericService<Customer>
{
    List<Customer> GetByIsActive();
    List<Customer> GetByIsDeactive();

}
