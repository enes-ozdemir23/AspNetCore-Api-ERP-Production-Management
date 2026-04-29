using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpWebUI.Dtos.CustomerDtos
{
    public class GetCustomerDto
    {
        public string CustomerCode { get; set; } = null!;
        public string? CustomerName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Type { get; set; }
    }
}
