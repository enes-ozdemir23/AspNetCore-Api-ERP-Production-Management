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
    public class OurTeamManager:IOurTeamService
    {
        private readonly IOurTeamDal _ourTeamDal;

        public OurTeamManager(IOurTeamDal ourTeamDal)
        {
            _ourTeamDal = ourTeamDal;
        }

        public void TAdd(OurTeam entity)
        {
            _ourTeamDal.Add(entity);    
        }

        public void TDelete(OurTeam entity)
        {
            _ourTeamDal.Delete(entity);
        }

        public OurTeam TGetByID(int id)
        {
            return _ourTeamDal.GetByID(id);
        }

        public List<OurTeam> TGetListAll()
        {
            return _ourTeamDal.GetListAll();
        }

        public void TUpdate(OurTeam entity)
        {
            _ourTeamDal.Update(entity);
        }
    }
}
