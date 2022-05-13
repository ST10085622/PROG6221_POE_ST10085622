using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE
{
    abstract class AExpenses
    {

        public static float[] expArray = new float[5];
        public static float grossInc = 0.00f;
        public static float taxDed;
        public static float rent;
        public static double propPrice;
        public static float ideposit;
        public static double finterest;
        public static float numMonths;
       

        //public void AExpenses(float income)
        //{

        //    this.grossInc = income;
        //    this.taxDed = tax;
        //    this.expArray = expArray;

        //}


        /*   
        public float groceries = 0;
        public float w_lights = 0;
        public float travel = 0;
        public float teleBills = 0;
        public float oExpenses = 0;
        */

        public void setGrossIncome(float income)
        {
            grossInc  = income;
        }
        public void setTax(float tax)
        {
            taxDed = tax;
        }
        public void setGroceries(float groc)
        {
            expArray[0] = groc;
        }
        public void setWater_Lights(float wLights)
        {
            expArray[1] = wLights;
        }
        public void setTravelCost(float tCost)
        {
            expArray[2] = tCost;
        }
        public void setCellphone(float cell)
        {
            expArray[3] = cell;
        }
        public void setOtherExpenses(float otherExpenses)
        {
            expArray[4] = otherExpenses;
        }


        public float getGrossIncome()
        {
            return grossInc;
        }
        public float getTaxDeduction()
        {
            return taxDed;
        }
        public float getGroceries()
        {
            return expArray[0];
        }
        public float getWater_Lights()
        {
            return expArray[1];
        }
        public float getTravelCost()
        {
            return expArray[2];
        }
        public float getCellphoneBills()
        {
            return expArray[3];
        }
        public float getOtherExpenses()
        {
            return expArray[4];
        }
        
        public virtual void HomeLoan(double price, float deposit, double interest, float nMonths)
        {
           
            price = propPrice;
            deposit = ideposit;
            interest = finterest/100;
            nMonths = numMonths;

            //price = deposit * (1 + interest / nMonths);
            //Console.WriteLine("\n-------------------------------------------------------" +
            //    "\nThe total monthly installment for the house is = " + price);

            //if(price > ((1/3)*grossInc))
            //{
            //    Console.WriteLine("The approval of the home loan is unlikely");
            //}
            //else
            //{
            //    float expenses = expArray.Sum();
            //    float tot = grossInc - ( expenses + taxDed) - price;
            //    Console.WriteLine("The available monthly money after all the specified deductions have been made = R" + tot);
            //}
            
        }
         public virtual void renting(float fRent)
        {
            fRent = rent;

           // float tot = grossInc - (expArray.Sum() + taxDed) - fRent;
            //Console.WriteLine("-------------------------------------------------------------------");
            //Console.WriteLine("\nThe available monthly money after all the specified deductions have been made = R" + tot);

        }

        

    }
}
