using Factory.Models;
using System;

namespace Factory.Processors
{
    public abstract class PaymentProcessor
    {
        public abstract PaymentTransaction Pay(object payload);
        public virtual bool LogTransaction(PaymentTransaction transaction)
        {
            // Default implementation Log to DB, etc .. 
            Console.WriteLine("Base Log Transaction...");
            return true;
        }

        public PaymentProcessor()
        {

        }
    }
}
