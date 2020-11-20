using Factory.Common;
using Factory.Models;

namespace Factory.Processors
{
    public class DebitCardProcessor : PaymentProcessor
    {
        public override PaymentTransaction Pay(object payload)
        {
            // Generate transaction, process, log, save, etc.
            PaymentTransaction transaction = new PaymentTransaction(payload, PaymentStatus.Success, PaymentType.Cash);
            LogTransaction(transaction);

            return transaction;    
        }
    }
}
