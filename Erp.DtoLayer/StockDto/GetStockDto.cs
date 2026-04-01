using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.DtoLayer.StockDto
{
    public class GetStockDto
    {
        public string StockCode { get; set; } = null!;
        public string? StockName { get; set; }
        public string? GroupCode { get; set; }
        public decimal? Price { get; set; }
        public decimal? Vat { get; set; }
    }
}
