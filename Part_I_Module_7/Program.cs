using System;

namespace Part_I_Module_7
{
    abstract class Delivery
    {
        public string Address;
    }

    abstract class Payment
    {
        public string Status;
    }

    class Prepayment : Payment
    {
        /* ... */
    }

    class PayOnDelivery : Payment
    {
        /* ... */
    }

    class PostponedPayment : Payment
    {
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

    class Order<TDelivery,
    TStruct, TPayment> where TDelivery : Delivery where TPayment : Payment
    {
        public TDelivery Delivery;

        public TPayment Payment;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        public void DisplayPaymentStatus()
        {
            Console.WriteLine(Payment.Status);
        }
        // ... Другие поля
    }
}
