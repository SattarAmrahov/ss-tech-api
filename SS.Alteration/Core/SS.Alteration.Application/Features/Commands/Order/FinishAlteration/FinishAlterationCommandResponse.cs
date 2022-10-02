namespace SS.Alteration.Application.Features.Commands.Order.FinishAlteration
{
    public class FinishAlterationCommandResponse
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        public string OrderStatus { get; set; }
        public string SuitCode { get; set; }
    }
}
