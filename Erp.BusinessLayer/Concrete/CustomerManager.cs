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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TAdd(Customer entity)
        {
            _customerDal.Add(entity);
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public Customer TGetByID(string code)
        {
            return _customerDal.GetByID(code);
        }

        public List<Customer> TGetListAll()
        {
            return _customerDal.GetListAll();
        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
