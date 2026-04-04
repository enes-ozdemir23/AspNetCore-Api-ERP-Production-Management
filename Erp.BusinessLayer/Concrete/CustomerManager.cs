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
        private readonly ICodeGeneratorService _codegenService;
        public CustomerManager(ICustomerDal customerDal, ICodeGeneratorService codegenService)
        {
            _customerDal = customerDal;
            _codegenService = codegenService;
        }

        public void TAdd(Customer entity)
        {
            var lastCode = _customerDal.GetLastCustomerCode();
            entity.CustomerCode = _codegenService.GenerateCustomerCode(lastCode,"320.01");
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

        public string TGetLastCustomerCode()
        {
            return _customerDal.GetLastCustomerCode();
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
