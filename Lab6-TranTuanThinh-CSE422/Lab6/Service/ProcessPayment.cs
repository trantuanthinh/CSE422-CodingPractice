using Lab6.Interface;
using Lab6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Service
{
    public class PaymentService
    {
        public void ProcessPayment(string method, double amount)
        {
            IPayment paymentStrategy = FactoryPayment.GetPaymentMethod(method);
            paymentStrategy.ProcessPayment(amount);
        }
    }

}
