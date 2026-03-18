using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.DataAccessLayer.Abstract;
using Erp.DataAccessLayer.Concrete.Context;

namespace Erp.DataAccessLayer.Repositories
{
    public class GenericRepository<T,TId> : IGenericDal<T,TId> where T : class
    {
        private readonly ErpContext _context;

        public GenericRepository(ErpContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public T GetByID(TId id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
