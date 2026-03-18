using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.BusinessLayer.Abstract
{
    public interface IGenericService<T,TId> where T : class
    {
        void TAdd(T entity);

        void TDelete(T entity);

        void TUpdate(T entity);

        T TGetByID(TId id);

        List<T> TGetListAll();
    }
}
