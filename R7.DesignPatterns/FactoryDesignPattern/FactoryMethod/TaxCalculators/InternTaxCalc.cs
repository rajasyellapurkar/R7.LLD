namespace R7.DesignPattern.FactoryDesignPattern.FactoryMethod.TaxCalculators
{
    public class InternTaxCalc : ITaxCalculator
    {
        public double CalculateTax(double salary)
        {
            return 0.10 * salary;
        }
    }
}
