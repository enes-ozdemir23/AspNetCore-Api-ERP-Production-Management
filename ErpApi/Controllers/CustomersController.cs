using AutoMapper;
using Erp.BusinessLayer.Abstract;
using Erp.DtoLayer.CustomerDto;
using Erp.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public CustomersController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult CustomerList()
        {
            var values = _mapper.Map<List<ResultCustomerDto>>(_customerService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddCustomer(CreateCustomerDto createCustomerDto)
        {
            var values=_mapper.Map<Customer>(createCustomerDto);
            _customerService.TAdd(values);
            return Ok("İşlem Başarılı");
        }
        [HttpDelete]
        public IActionResult DeleteCustomer(string code)
        {
            var values = _customerService.TGetByID(code);
            _customerService.TDelete(values);
            return Ok("İşlem Başarılı");
        }
        [HttpPut]
        public IActionResult UpdateCustomer(UpdateCustomerDto updateCustomerDto)
        {
            var values= _mapper.Map<Customer>(updateCustomerDto);
            _customerService.TUpdate(values);
            return Ok("Güncelleme Başarılı");
        }

        [HttpGet("{code}")]
        public IActionResult GetCustomer(string code)
        {
            var values = _customerService.TGetByID(code);
            return Ok(_mapper.Map<GetCustomerDto>(values));
        }

    }
}
