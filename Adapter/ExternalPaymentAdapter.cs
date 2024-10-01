public class ExternalPaymentAdapter : IPaymentProcessor
{
    private readonly ExternalPaymentService _externalPaymentService;

    public ExternalPaymentAdapter(ExternalPaymentService externalPaymentService)
    {
        _externalPaymentService = externalPaymentService;
    }

    public void ProcessPayment(decimal amount)
    {
        _externalPaymentService.MakeExternalPayment(amount);
    }

}