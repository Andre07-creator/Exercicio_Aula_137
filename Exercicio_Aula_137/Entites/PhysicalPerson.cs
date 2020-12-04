using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Aula_137.Entites
{
    class PhysicalPerson : Person
    {
        public double ExpensesHealth { get; set; }

        public PhysicalPerson(double expensesHealth, string name, double annualIncome)
            : base(name, annualIncome)
        {
            ExpensesHealth = expensesHealth;
        }
        public override double TaxCalc()
        {
            if(AnnualIncome <= 20000.00)
            {
            return (AnnualIncome * 15 / 100) - (ExpensesHealth * 50 / 100);
            }
            else
            {
                return (AnnualIncome * 25 / 100) - (ExpensesHealth * 50 / 100);
            }
        }
    }
}
