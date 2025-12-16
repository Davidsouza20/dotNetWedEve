namespace dotNetWedEve
{
    public enum TransactionType
    {
        Expense,
        Income
    }

    public class Transaction
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required decimal Amount { get; set; }
        public required Category Category { get; set; }
        public required TransactionType Type { get; set; }
        public DateTime Date { get; set; }
        public string? Notes { get; set; }
    }
}