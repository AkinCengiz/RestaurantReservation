using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Business.Abstract;
using RestaurantReservation.DataAccess.Abstract;
using RestaurantReservation.Entities.Concrete;

namespace RestaurantReservation.Business.Concrete;
public class TableManager : ITableService
{
    private ITableDal _tableDal;

    public TableManager(ITableDal tableDal)
    {
        _tableDal = tableDal;
    }

    public void Add(Table entity)
    {
        _tableDal.Add(entity);
    }

    public void Update(Table entity)
    {
        _tableDal.Update(entity);
    }

    public void Delete(Table entity)
    {
        _tableDal.Delete(entity);
    }

    public List<Table> GetAll()
    {
        return _tableDal.GetList(t => t.IsDeleted == false);
    }

    public List<Table> GetListUnConditional()
    {
        return _tableDal.GetList();
    }

    public Table Get(int id)
    {
        return _tableDal.Get(t => t.Id == id);
    }

    public List<Table> GetListByIsActive()
    {
        return _tableDal.GetList(t => t.IsActive == true);
    }

    public List<Table> GetListByInactive()
    {
        return _tableDal.GetList(t => t.IsActive == false);
    }
}
