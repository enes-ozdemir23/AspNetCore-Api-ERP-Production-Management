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
        private readonly ICodeGeneratorService _codeGenerator;

        public GroupCodeManager(IGroupCodeDal groupCodeDal, ICodeGeneratorService codeGenerator)
        {
            _groupCodeDal = groupCodeDal;
            _codeGenerator = codeGenerator;
        }

        public string TGetLastGroupCode()
        {
            return _groupCodeDal.GetLastGroupCode();
        }

        public void TAdd(GroupCode entity)
        {
            var lastCode = _groupCodeDal.GetLastGroupCode();
            entity.GroupCodeValue = _codeGenerator.GenerateGroupCode(lastCode);
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
