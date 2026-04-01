using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.DtoLayer.StockMovementDto
{
    public class ResultStockMovementDto
    {
        public int StockMovementId { get; set; }
        public string? ProductionResultCode { get; set; }
        public string? WorkOrderCode { get; set; }
        public string? StockCode { get; set; }
        public string? StockName { get; set; }
        public decimal? IncomingAmount { get; set; }
        public decimal? OutgoingAmount { get; set; }
        public string? CustomerName { get; set; }
        public string? ProductionResultDescription { get; set; }
    }
}
