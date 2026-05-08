using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.DataAccessLayer.Abstract;
using Erp.DataAccessLayer.Concrete.Context;
using Erp.DataAccessLayer.Repositories;
using Erp.EntityLayer.Entities;

namespace Erp.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact, int>, IContactDal
    {
        public EfContactDal(ErpContext context) : base(context)
        {
        }
    
    }
}
