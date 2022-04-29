using System;

namespace Part_I_Module_7
{
    class Program
    {
        static void Main()
        {

            /* ... */

        }
        abstract class Delivery
        {
            public string Address;
        }

        abstract class Payment
        {
            public string Status;
            public int Total_Sum;
            public bool IsPaid;
            public string TimeOfPayment;
            public string NameOfBank;

            public Payment(string status, int sum)
            {
                Status = status;
                Total_Sum = sum;
            }
        }

        class Prepayment : Payment
        {
            public Prepayment(string status, int sum, bool ispaid) : base(status, sum)
            {
                IsPaid = ispaid;
            }
            /* ... */
        }

        class PayOnDelivery : Payment
        {
            public PayOnDelivery(string status, int sum, string timeOfPayment) : base(status, sum)
            {
                TimeOfPayment = timeOfPayment;
            }
            /* ... */
        }

        class PostponedPayment : Payment
        {
            public PostponedPayment(string status, int sum, string nameOfBank) : base(status, sum)
            {
                NameOfBank = nameOfBank;
            }
            /* ... */
        }

        class HomeDelivery : Delivery
        {
            /* ... */
        }

        class PickPointDelivery : Delivery
        {
            /* ... */
        }

        class ShopDelivery : Delivery
        {
            /* ... */
        }

        class Order <TDelivery, TStruct, TPayment> where TDelivery : Delivery where TPayment : Payment
        {
            public TDelivery Delivery;

            public int Number;

            public string Description;

            public void DisplayAddress()
            {
                Console.WriteLine(Delivery.Address);
            }

            // ... Другие поля

            public TPayment Payment;
            public void DisplayPaymentStatus()
            {
                Console.WriteLine(Payment.Status);
                Console.WriteLine(Payment.NameOfBank ?? "Оплата от клиента");
                Console.WriteLine(Payment.TimeOfPayment ?? "Оформлено по предоплате или отсрочке платежа");
                Console.WriteLine(Payment.Total_Sum);
            }

        }
    }
}
