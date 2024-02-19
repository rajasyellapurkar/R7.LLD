using R7.DesignPattern.FactoryDesignPattern.FactoryMethod.TaxCalculators;
using System;

namespace R7.DesignPattern.FactoryDesignPattern.FactoryMethod
{
    public static class FactoryMethodMain
    {
        public static void Entry()
        {

            Console.WriteLine($"----- Factory Method ----------");

            Employee fullTimeEmp = new FullTimeEmp();
            fullTimeEmp.Salary = 100000;
            Employee partTimeEmp = new PartTimeEmp();
            partTimeEmp.Salary = 60000;
            Employee intern = new Intern();
            intern.Salary = 25000;

            Console.WriteLine($"FullTime Employee Tax: {TaxSystem.GetInstance(fullTimeEmp).CalculateTax(fullTimeEmp.Salary)}");
            Console.WriteLine($"PartTime Employee Tax: {TaxSystem.GetInstance(partTimeEmp).CalculateTax(partTimeEmp.Salary)}");
            Console.WriteLine($"Intern Employee Tax: {TaxSystem.GetInstance(intern).CalculateTax(intern.Salary)}");
        }
    }
}
