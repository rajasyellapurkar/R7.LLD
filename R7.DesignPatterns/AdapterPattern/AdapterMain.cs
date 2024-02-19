using R7.DesignPattern.AdapterPattern.Adapters;

/// Adapater Pattern allows object with incompatible interfaces to collaborate
namespace R7.DesignPattern.AdapterPattern
{
    public static class AdapterMain
    {
        public static void Entry()
        {
            Swiggy swiggy = new Swiggy(new RazorPayAdapter());

            swiggy.Pay();
        }
    }
}
