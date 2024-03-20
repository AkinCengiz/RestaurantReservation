using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Entities.Concrete;

namespace RestaurantReservation.DataAccess.Concrete.EntityFramework.Contexts;
public class RestaurantReservationContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=ACENGIZ\AKINCENGIZ; initial catalog=RestaurantReservationDb;Integrated Security=True;Trust Server Certificate=True;");
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Menu> Menus { get; set; }
}
