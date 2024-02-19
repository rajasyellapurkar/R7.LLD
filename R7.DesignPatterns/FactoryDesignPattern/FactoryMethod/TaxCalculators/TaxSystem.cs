namespace R7.DesignPattern.FactoryDesignPattern.FactoryMethod.TaxCalculators
{
    public static class TaxSystem
    {
        public static ITaxCalculator GetInstance(Employee employee)
        {
            if (employee is FullTimeEmp)
            {
                return new FullTimeTaxCalc();
            } 
            else if (employee is PartTimeEmp)
            {
                return new PartTimeTaxCalc();
            }
            else if (employee is Intern)
            {
                return new InternTaxCalc();
            }
            return null;
        }
    }
}
