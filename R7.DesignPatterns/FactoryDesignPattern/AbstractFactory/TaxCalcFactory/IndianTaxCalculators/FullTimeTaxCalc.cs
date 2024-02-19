using R7.DesignPattern.FactoryDesignPattern.AbstractFactory.TaxCalculators;

namespace R7.DesignPattern.FactoryDesignPattern.AbstractFactory.TaxCalcFactory.IndianTaxCalculators
{
    public class FullTimeTaxCalc : ITaxCalculator
    {
        public double CalculateTax(double salary)
        {
            return 0.30 * salary;
        }
    }
}
