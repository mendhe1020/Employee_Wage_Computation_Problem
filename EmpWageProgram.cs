using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Problem
{
    public static class EmpWageProgram
    {
        const int WagePrHr = 20;
        const int FullDayHr = 8;
        const int PartTimeHr = 4;
        const int NumOfWorkingDays = 20;
        public static void EmpWage()
        {
            int TotalEmpWage = 0;
            int EmpWage = 0;

            for(int day =0;day<NumOfWorkingDays;day++)
            {
                Random random = new Random();
                int Empis = random.Next(3);

                switch(Empis)
                {
                    case 1 :
                        Console.WriteLine(WagePrHr * FullDayHr);
                        break;

                    case 2 :
                        Console.WriteLine(WagePrHr * PartTimeHr);
                        break;

                    default:
                        Console.WriteLine("Emp is Abcent");
                        break;

                }

            }
            EmpWage = WagePrHr * PartTimeHr;
            TotalEmpWage += EmpWage;
            Console.WriteLine(TotalEmpWage);
            




        }
    }
}
