using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.DtoLayer.ProductionResultDto
{
    public class ResultProductionResultDto
    {       
        public string ProductionResultCode { get; set; } = null!;
        public string? WorkOrderCode { get; set; }
        public string? StockCode { get; set; }
        public string? StockName { get; set; }
        public decimal? ProductionResultAmount { get; set; }
        public string? OrderCode { get; set; }
        public int? OrderItemId { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
    }
}
