namespace ErpWebUI.Dtos.StockDtos
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
