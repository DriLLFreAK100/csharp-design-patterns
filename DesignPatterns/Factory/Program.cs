using Factory.Common;
using Factory.Models;
using Factory.Processors;
using System;

/// <summary>
/// A type of Creational Pattern that enables object creations without specifying concrete type. 
/// Return type can be represented by an Interface or an Abstract Base Class
/// In this example, we'll go with Abstract Base Class implementation
/// 
/// The example is written based on a PaymentProcessor implementation in a retail scenario
/// A customer can pay by cash, credit card, debit card, voucher, etc
///
/// </summary>
namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // ... Probably inside a part of transaction engine. 
            // Here, we just assume that the payment type is Credit Card.
            PaymentType type = PaymentType.CreditCard;
            CreditCardPayload payloadReceived = new CreditCardPayload(10.20M, "VISA", "4539804400071285");
            PaymentProcessor processor = null;

            switch (type)
            { 
                case PaymentType.Cash:
                    processor = new CashProcessor();
                    break;
                case PaymentType.CreditCard:
                    processor = new CreditCardProcessor();
                    break;
                case PaymentType.DebitCard:
                    processor = new DebitCardProcessor();
                    break;
                case PaymentType.Voucher:
                    processor = new VoucherProcessor();
                    break;
                default:
                    throw new Exception("Invalid Payment Type");
            }

            var transaction = processor.Pay(payloadReceived);
            Console.WriteLine($"PaymentTransaction - Status: {transaction.PaymentStatus.ToString()}, CreatedTime: {transaction.CreatedTime}");
            // ... subsequent processes
        }
    }
}
