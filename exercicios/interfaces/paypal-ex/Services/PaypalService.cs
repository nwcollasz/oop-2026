namespace paypal_ex.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private const double PaymentFeeRate = 0.02; 
        private const double SimpleTaxRate = 0.01;

        public double PaymentFee(double amount)
        {
            return amount * PaymentFeeRate;
        }

        public double Interest(double amount, int months)
        {
            return amount * SimpleTaxRate * months;
        }
    }
}