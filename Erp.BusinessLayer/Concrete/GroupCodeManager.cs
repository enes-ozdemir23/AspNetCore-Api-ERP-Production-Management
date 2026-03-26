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
    public class GroupCodeManager : IGroupCodeService
    {
        private readonly IGroupCodeDal _groupCodeDal;

        public GroupCodeManager(IGroupCodeDal groupCodeDal)
        {
            _groupCodeDal = groupCodeDal;
        }

        public void TAdd(GroupCode entity)
        {
            _groupCodeDal.Add(entity);
        }

        public void TDelete(GroupCode entity)
        {
            _groupCodeDal.Delete(entity);
        }

        public GroupCode TGetByID(string id)
        {
            return _groupCodeDal.GetByID(id);
        }

        public List<GroupCode> TGetListAll()
        {
            return _groupCodeDal.GetListAll();
        }

        public void TUpdate(GroupCode entity)
        {
            _groupCodeDal.Update(entity);
        }
    }
}
