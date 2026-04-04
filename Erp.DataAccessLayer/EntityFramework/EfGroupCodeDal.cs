using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.DataAccessLayer.Abstract;
using Erp.DataAccessLayer.Concrete.Context;
using Erp.DataAccessLayer.Repositories;
using Erp.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Erp.DataAccessLayer.EntityFramework
{
    public class EfGroupCodeDal : GenericRepository<GroupCode, string>, IGroupCodeDal
    {
        public EfGroupCodeDal(ErpContext context) : base(context)
        {
        }

        public string GetLastGroupCode()
        {
            var context=new ErpContext();
            var value= context.GroupCodes
                   .OrderByDescending(x => x.GroupCodeValue)
                   .Select(y => y.GroupCodeValue)
                   .FirstOrDefault();
            return value;
        }
    }
}
