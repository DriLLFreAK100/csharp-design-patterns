namespace Factory.Models
{
    public class CreditCardPayload
    {
        public decimal Amount { get; set; }
        public string Brand { get; set; }
        public string CardNumber { get; set; }

        public CreditCardPayload(decimal amount, string brand, string cardNumber)
        {
            Amount = amount;
            Brand = brand;
            CardNumber = cardNumber;
        }
    }
}
