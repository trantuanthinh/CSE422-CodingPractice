using Lab6.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Model
{
    internal class FactoryPayment
    {
        public static IPayment GetPaymentMethod(string method)
        {
            return method.ToLower() switch
            {
                "creditcard" => new CreditCardPayment(),
                "paypal" => new PayPalPayment(),
                "crypto" => new CryptoPayment(),
                _ => throw new ArgumentException("Invalid payment method"),
            };
        }
    }
}
