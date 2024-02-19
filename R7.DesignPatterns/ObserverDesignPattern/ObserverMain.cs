namespace R7.DesignPattern.ObserverDesignPattern
{
    internal class ObserverMain
    {
        public static void Entry()
        {
            IBitcoinObserver emailSender = new EmailSender();
            IBitcoinObserver tweetHanlder = new Tweeter();
            IBitcoinObserver purchaseHandler = new Purchase();

            Bitcoin bitcoin = new Bitcoin();
            bitcoin.AddObserver(emailSender);
            bitcoin.AddObserver(tweetHanlder);
            bitcoin.AddObserver(purchaseHandler);

            bitcoin.Price = 199;
        }
    }
}
