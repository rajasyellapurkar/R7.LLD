using R7.DesignPattern.FactoryDesignPattern.AbstractFactory.TaxCalculators;

namespace R7.DesignPattern.FactoryDesignPattern.AbstractFactory.TaxCalcFactory.IndianTaxCalculators
{
    public class InternTaxCalc : ITaxCalculator
    {
        public double CalculateTax(double salary)
        {
            return 0.10 * salary;
        }
    }
}
