using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Aula_137.Entites
{
    class CorporatePerson : Person
    {
        public int NumEmployees { get; set; }

        public CorporatePerson(int numEmployees, string name, double annualIncome)
            : base(name, annualIncome)
        {
            NumEmployees = numEmployees;
        }
        public override double TaxCalc()
        {
            if (NumEmployees <= 10)
            {
                return AnnualIncome * 16 / 100;
            }
            else
            {
                return AnnualIncome * 14 / 100;
            }
        }
    }
}
