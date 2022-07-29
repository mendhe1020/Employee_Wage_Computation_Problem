using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Problem
{
    public static class EmpWageProgram
    {
        public static void EmpWage()
        {
            int WagePrHr = 20;
            int FullDayHr = 8;
            int PartTimeHr = 4;

            Random random = new Random();
            int Empis = random.Next(3);

            if (Empis == 0)
            {
                Console.WriteLine("Emploee is Present");
                Console.WriteLine(WagePrHr * FullDayHr);
            }
            else if (Empis == 1)
            {
                Console.WriteLine("Emp is part time present");
                Console.WriteLine(WagePrHr * PartTimeHr);
            }
            else
            {
                Console.WriteLine("Emploee is Abcent");
            }
        }
    }
}
