using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.DtoLayer.OrderItemDto
{
    public class CreateOrderItemDto
    {
        public string? OrderCode { get; set; }
        public string? StockCode { get; set; }
        public string? StockName { get; set; }
        public decimal? OrderItemAmount { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? Vat { get; set; }
        public string? OrderItemStatus { get; set; }
    }
}
