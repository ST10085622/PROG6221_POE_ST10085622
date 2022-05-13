using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE
{
    class AHouse : AExpenses
    {
        

        public AHouse(float income, float tax, float[] eArray, float irent)
        {
            grossInc = income;
            taxDed = tax;
            expArray = eArray;
            rent = irent;

        }


        public override void HomeLoan(double price, float deposit, double interest, float nMonths)
        {
            
            //Program pr = new Program();
            propPrice = price;
            ideposit = deposit;
            finterest = interest*0.10;
            numMonths = nMonths;

            price = deposit * (1 + (interest / nMonths));
            Console.WriteLine("\n-------------------------------------------------------" +
                "\nThe total monthly installment for the house is = R" + Math.Round(propPrice, (2)));

            if (price >= ((1 / 3) * grossInc))
            {
                Console.WriteLine("The approval of the home loan is unlikely.");
                double tot = (grossInc - (expArray.Sum() + taxDed)) - price;
                Console.WriteLine("The available monthly money after all the specified deductions have been made = R" + Math.Round(tot, (2)));
            }
            else
            {
                
                double expenses = expArray.Sum();
                double tot = (grossInc - (expenses + taxDed)) - price;
                Console.WriteLine("The approval of the home loan is likely.");
                Console.WriteLine("The available monthly money after all the specified deductions have been made = R" + Math.Round(tot, (2)));
            }

        }

        public override void renting(float fRent)
        {
            rent = fRent;
            double tot =  (grossInc - (expArray.Sum() + taxDed)) - fRent;
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("\nThe available monthly money after all the specified deductions have been made = R" + Math.Round(tot, (2)));

        }


    }
}
