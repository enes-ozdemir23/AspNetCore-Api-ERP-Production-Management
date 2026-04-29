namespace ErpWebUI.Dtos.CustomerDtos
{
    public class ResultCustomerDto
    {
        public string CustomerCode { get; set; } = null!;
        public string? CustomerName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Type { get; set; }
    }
}
