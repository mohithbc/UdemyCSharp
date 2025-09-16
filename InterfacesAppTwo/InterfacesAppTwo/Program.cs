namespace InterfacesAppTwo
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit card payment of {amount:C}");
        }
    }
    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
        }
    }
    public class PaymentService
    {
        private readonly IPaymentProcessor _paymentProcessor;
        public PaymentService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }
        public void ProcessOrderPayment(decimal amount)
        {
            _paymentProcessor.ProcessPayment(amount);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using CreditCardProcessor
            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            PaymentService paymentService = new PaymentService(creditCardProcessor);
            paymentService.ProcessOrderPayment(100.00m);
            // Switch to PayPal processor
            IPaymentProcessor payPalProcessor = new PayPalProcessor();
            paymentService = new PaymentService(payPalProcessor);
            paymentService.ProcessOrderPayment(150.00m);
        }
    }
}
