using Factory.Common;
using System;

namespace Factory.Models
{
    public class PaymentTransaction
    {
        public string Id { get; set; }
        public object Payload { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public PaymentType PaymentType { get; set; }
        public DateTime CreatedTime { get; set; }

        public PaymentTransaction(object payload, PaymentStatus paymentStatus, PaymentType paymentType)
        {
            Id = Guid.NewGuid().ToString();
            CreatedTime = DateTime.Now;
            Payload = payload;
            PaymentStatus = paymentStatus;
            PaymentType = paymentType;
        }
    }
}
