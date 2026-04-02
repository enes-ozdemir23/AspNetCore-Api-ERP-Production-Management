using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.DtoLayer.OrderDto
{
    public class UpdateOrderDto
    {
        public string OrderCode { get; set; } = null!;
        public string? CustomerCode { get; set; }
        public string? OrderDate { get; set; }
        public string? OrderDeliveryDate { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
