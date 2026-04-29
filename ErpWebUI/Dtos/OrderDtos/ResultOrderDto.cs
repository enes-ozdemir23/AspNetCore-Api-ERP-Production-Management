namespace ErpWebUI.Dtos.OrderDtos
{
    public class ResultOrderDto
    {
        public string OrderCode { get; set; } = null!;
        public string? CustomerCode { get; set; }
        public string? OrderDate { get; set; }
        public string? OrderDeliveryDate { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
