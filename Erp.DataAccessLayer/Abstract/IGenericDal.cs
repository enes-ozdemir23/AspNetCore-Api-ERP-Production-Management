using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.DataAccessLayer.Abstract
{
    public interface IGenericDal<T,TId> where T : class
    {
        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        T GetByID(TId id);

        List<T> GetListAll();
    }
}
