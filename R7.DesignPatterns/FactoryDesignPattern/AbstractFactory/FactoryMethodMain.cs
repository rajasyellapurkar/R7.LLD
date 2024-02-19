using R7.DesignPattern.FactoryDesignPattern.AbstractFactory.TaxCalcFactory;
using System;

namespace R7.DesignPattern.FactoryDesignPattern.AbstractFactory
{
    public static class AbstractFactoryMain
    {
        public static void Entry()
        {
            string countryCode = "in";
            Console.WriteLine($"----- Abstract Factory Method ----------");

            Employee fullTimeEmp = new FullTimeEmp();
            fullTimeEmp.Salary = 100000;
            Employee partTimeEmp = new PartTimeEmp();
            partTimeEmp.Salary = 60000;
            Employee intern = new Intern();
            intern.Salary = 25000;
            ITaxFactory taxCalcFactory = null;

            if (countryCode == "in")
            {
                taxCalcFactory = new IndianTaxCalcFactory();
            }
            else if (countryCode == "us")
            {
                // Create USTaxCalcFactory instance
            }

            Console.WriteLine($"FullTime Employee Tax: {taxCalcFactory?.GetTaxCalculator(fullTimeEmp).CalculateTax(fullTimeEmp.Salary)}");
            Console.WriteLine($"PartTime Employee Tax: {taxCalcFactory?.GetTaxCalculator(partTimeEmp).CalculateTax(partTimeEmp.Salary)}");
            Console.WriteLine($"Intern Employee Tax: {taxCalcFactory?.GetTaxCalculator(intern).CalculateTax(intern.Salary)}");
        }
    }
}
