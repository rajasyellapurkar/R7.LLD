using R7.DesignPattern.FactoryDesignPattern.AbstractFactory.TaxCalculators;

namespace R7.DesignPattern.FactoryDesignPattern.AbstractFactory.TaxCalcFactory
{
    public interface ITaxFactory
    {
        ITaxCalculator CreateFullTimeCalc();
        ITaxCalculator CreatePartTimeCalc();
        ITaxCalculator CreateInternTaxCalc();
        ITaxCalculator GetTaxCalculator(Employee employee);
    }
}
