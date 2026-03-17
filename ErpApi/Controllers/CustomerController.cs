using Erp.BusinessLayer.Abstract;
using Erp.DataAccessLayer.Concrete.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpGet]
        public IActionResult CustomerList()
        {
            var values = _customerService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _customerService.TAdd(customer);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteCustomer(string code)
        {
            var values = _customerService.TGetByID(code);
            _customerService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customerService.TUpdate(customer);
            return Ok();
        }

        [HttpGet("{code}")]
        public IActionResult GetCustomer(string code)
        {
            var values = _customerService.TGetByID(code);
            return Ok(values);
        }

    }
}
