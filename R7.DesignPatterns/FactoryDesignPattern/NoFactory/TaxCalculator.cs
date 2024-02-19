namespace R7.DesignPattern.FactoryDesignPattern.NoFactory
{
    public class TaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double salary)
        {
            return 0.10 * salary;
        }
    }
}
