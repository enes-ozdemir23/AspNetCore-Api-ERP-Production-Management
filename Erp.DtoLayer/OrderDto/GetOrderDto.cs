using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.DtoLayer.OrderDto
{
    public class GetOrderDto
    {
        public string OrderCode { get; set; } = null!;
        public string? CustomerCode { get; set; }
        public string? OrderDate { get; set; }
        public string? OrderDeliveryDate { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
