namespace R7.DesignPattern.FactoryDesignPattern.FactoryMethod.TaxCalculators
{
    public class FullTimeTaxCalc : ITaxCalculator
    {
        public double CalculateTax(double salary)
        {
            return 0.30 * salary;
        }
    }
}
