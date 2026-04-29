using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpWebUI.Dtos.WorkOrderDtos
{
    public class UpdateWorkOrderDto
    {
        public string WorkOrderCode { get; set; } = null!;
        public string? StockCode { get; set; }
        public string? StockName { get; set; }
        public string? Description { get; set; }
        public string? WorkOrderDate { get; set; }
        public string? DeliveryDate { get; set; }
        public string? OrderCode { get; set; }
        public decimal? WorkOrderAmount { get; set; }
        public int? OrderItemId { get; set; }
        public string? WorkOrderStatus { get; set; }
    }
}
