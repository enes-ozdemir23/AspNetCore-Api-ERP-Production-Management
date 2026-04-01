using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.DtoLayer.StockDto
{
    public class ResultStockDto
    {
        public string StockCode { get; set; } = null!;
        public string? StockName { get; set; }
        public string? GroupCode { get; set; }
        public decimal? Price { get; set; }
        public decimal? Vat { get; set; }
    }
}
