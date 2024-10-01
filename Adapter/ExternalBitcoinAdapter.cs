public class ExternalBitcoinAdapter : IPaymentProcessor
{
    private readonly ExternalBitCoinService _externalBitCoinService;

    public ExternalBitcoinAdapter(ExternalBitCoinService externalBitCoinService)
    {
        _externalBitCoinService = externalBitCoinService;
    }

    public void ProcessPayment(decimal amount)
    {
        _externalBitCoinService.TransferToWallet(amount);
    }
}