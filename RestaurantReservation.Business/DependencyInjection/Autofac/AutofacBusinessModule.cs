using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using RestaurantReservation.Business.Abstract;
using RestaurantReservation.Business.Concrete;
using RestaurantReservation.DataAccess.Abstract;
using RestaurantReservation.DataAccess.Concrete.EntityFramework;

namespace RestaurantReservation.Business.DependencyInjection.Autofac;
public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<CustomerManager>().As<ICustomerService>();
        builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();
    }
}
