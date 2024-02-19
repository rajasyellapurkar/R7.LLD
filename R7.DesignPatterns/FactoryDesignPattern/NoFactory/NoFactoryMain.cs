using System;
namespace R7.DesignPattern.FactoryDesignPattern.NoFactory
{
    public static class NoFactoryMain
    {
        public static void Entry()
        {

            Console.WriteLine($"----- NO Factory----------");
            ITaxCalculator taxCalculator = new TaxCalculator();

            Employee fullTimeEmp = new FullTimeEmp();
            fullTimeEmp.Salary = 100000;
            Employee partTimeEmp = new PartTimeEmp();
            partTimeEmp.Salary = 60000;
            Employee intern = new Intern();
            intern.Salary = 25000;

            Console.WriteLine($"FullTime Employee Tax: {taxCalculator.CalculateTax(fullTimeEmp.Salary)}");
            Console.WriteLine($"PartTime Employee Tax: {taxCalculator.CalculateTax(partTimeEmp.Salary)}");
            Console.WriteLine($"Intern Employee Tax: {taxCalculator.CalculateTax(intern.Salary)}");
        }
    }
}
