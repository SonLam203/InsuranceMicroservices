namespace PolicyService.Implementation.Application.DTOs
{
    public class PolicyDto
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
