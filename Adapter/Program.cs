var externalPaymentService = new ExternalPaymentService();
var externalBitCoinService = new ExternalBitCoinService();

IPaymentProcessor paymentBitcoinProcessor = new ExternalBitcoinAdapter(externalBitCoinService);
IPaymentProcessor paymentProcessor = new ExternalPaymentAdapter(externalPaymentService);

var paymentService = new PaymentService(paymentProcessor);
var paymentBitcoinService = new PaymentService(paymentBitcoinProcessor);

paymentService.MakePayment(100m);
paymentBitcoinService.MakePayment(1m);