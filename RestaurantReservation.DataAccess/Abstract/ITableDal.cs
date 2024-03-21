using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Table = RestaurantReservation.Entities.Concrete.Table;

namespace RestaurantReservation.DataAccess.Abstract;
public interface ITableDal : IEntityDal<Table>
{
}
