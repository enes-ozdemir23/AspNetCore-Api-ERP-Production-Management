using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.BusinessLayer.Abstract;
using Erp.DataAccessLayer.Abstract;
using Erp.EntityLayer.Entities;

namespace Erp.BusinessLayer.Concrete
{
    public class DistrictManager : IDistrictService
    {
        private readonly IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public void TAdd(District entity)
        {
            _districtDal.Add(entity);
        }

        public void TDelete(District entity)
        {
            _districtDal.Delete(entity);
        }

        public District TGetByID(int id)
        {
            return _districtDal.GetByID(id);
        }

        public List<District> TGetListAll()
        {
            return _districtDal.GetListAll();
        }

        public void TUpdate(District entity)
        {
            _districtDal.Update(entity);
        }
    }
}
