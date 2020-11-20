using Factory.Common;
using Factory.Models;
using System;

namespace Factory.Processors
{
    public class CreditCardProcessor : PaymentProcessor
    {
        public override PaymentTransaction Pay(object payload)
        {
            var creditCardPayload = payload as CreditCardPayload;

            // Check Card Validity, generate transaction, process, log, save, etc.
            if (creditCardPayload.CardNumber == "something not valid") 
            {
                PaymentTransaction failedTransaction = new PaymentTransaction(creditCardPayload, PaymentStatus.Error, PaymentType.CreditCard);
                LogTransaction(failedTransaction);
                return failedTransaction;
            }

            PaymentTransaction transaction = new PaymentTransaction(creditCardPayload, PaymentStatus.Success, PaymentType.CreditCard);
            LogTransaction(transaction);
            return transaction;
        }

        public override bool LogTransaction(PaymentTransaction transaction)
        {
            Console.WriteLine("Credit Card Log Transaction...");
            return true;
        }
    }
}
