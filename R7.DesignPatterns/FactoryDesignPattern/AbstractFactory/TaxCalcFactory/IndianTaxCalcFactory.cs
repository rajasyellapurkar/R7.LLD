using R7.DesignPattern.FactoryDesignPattern.AbstractFactory.TaxCalcFactory.IndianTaxCalculators;
using R7.DesignPattern.FactoryDesignPattern.AbstractFactory.TaxCalculators;

namespace R7.DesignPattern.FactoryDesignPattern.AbstractFactory.TaxCalcFactory
{
    public class IndianTaxCalcFactory : ITaxFactory
    {
        public ITaxCalculator CreateFullTimeCalc()
        {
            return new FullTimeTaxCalc();
        }

        public ITaxCalculator CreateInternTaxCalc()
        {
            return new InternTaxCalc();
        }

        public ITaxCalculator CreatePartTimeCalc()
        {
            return new PartTimeTaxCalc();
        }

        public ITaxCalculator GetTaxCalculator(Employee employee)
        {
            if (employee is FullTimeEmp)
            {
                return CreateFullTimeCalc();
            }
            else if (employee is PartTimeEmp)
            {
                return CreatePartTimeCalc();
            }
            else if (employee is Intern)
            {
                return CreateInternTaxCalc();
            }
            return null;
        }
    }
}
