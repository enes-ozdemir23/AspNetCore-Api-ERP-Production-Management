using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.BusinessLayer.Abstract;
using Erp.DataAccessLayer.Abstract;
using Erp.DataAccessLayer.Concrete.Context;

namespace Erp.BusinessLayer.Concrete
{
    public class CityManager : ICityService
    {
        private readonly ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public void TAdd(City entity)
        {
            _cityDal.Add(entity);
        }

        public void TDelete(City entity)
        {
            _cityDal.Delete(entity);
        }

        public City TGetByID(int id)
        {
            return _cityDal.GetByID(id);
        }

        public List<City> TGetListAll()
        {
            return _cityDal.GetListAll();
        }

        public void TUpdate(City entity)
        {
            _cityDal.Update(entity);
        }
    }
}
