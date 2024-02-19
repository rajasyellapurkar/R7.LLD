namespace R7.DesignPattern.FactoryDesignPattern.FactoryMethod.TaxCalculators
{
    public class PartTimeTaxCalc : ITaxCalculator
    {
        public  double CalculateTax(double salary)
        {
            return 0.15 * salary;
        }
    }
}
