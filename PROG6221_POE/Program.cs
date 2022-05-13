using System;

namespace PROG6221_POE
{
    class Program : AExpenses
    {

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {

                    Console.WriteLine("\n\n******* MONTHLY BUDGET PLANNER ******** ");
                    Console.Write("Please enter your gross monthly income : R");
                    grossInc = float.Parse(Console.ReadLine());
                    Console.Write("Please enter your monthly tax deductions : R");
                    taxDed = float.Parse(Console.ReadLine());
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("Thank You. Please proceed by entering your monthly expenses - ");
                    Console.Write("Groceries : R");
                    expArray[0] = float.Parse(Console.ReadLine());
                    Console.Write("Water and Lights : R");
                    expArray[1] = float.Parse(Console.ReadLine());
                    Console.Write("Travel costs : R  ");
                    expArray[2] = float.Parse(Console.ReadLine());
                    Console.Write("Cellphone and Telephone Bills : R");
                    expArray[3] = float.Parse(Console.ReadLine());
                    Console.Write("All other expenses : R");
                    expArray[4] = float.Parse(Console.ReadLine());
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("Will you be renting or buying a house ? Enter 0 if renting a house, or Enter 1 if your buying a house ");
                    int BorR = Convert.ToInt32(Console.ReadLine()); //Buying or Renting

                    //renting or buying switch
                    AHouse hs = new AHouse(grossInc, taxDed, expArray, rent);
                    //try
                    //{
                        switch (BorR)
                        {
                            case 0: //rent house input option 

                                Console.Write("Please enter your monthly rent amount : R");
                                rent = float.Parse(Console.ReadLine());
                                hs.renting(rent);
                                break;
                            case 1: // buying house option inout
                                Console.Write("Please enter the deposit : R");
                                ideposit = float.Parse(Console.ReadLine());
                                Console.Write("Please enter the Interest Rate : R");
                                finterest = float.Parse(Console.ReadLine());
                                Console.Write("Please enter the number of months to pay : ");
                                numMonths = float.Parse(Console.ReadLine());
                                hs.HomeLoan(propPrice, ideposit, finterest, numMonths);
                                break;
                            default:
                                break;
                        }
                    //}
                    //catch (FormatException g)
                    //{
                    //    Console.WriteLine();

                    //    Console.WriteLine(g.Message + "\n PLEASE RE-ENTER VALUE.");
                    //}
                    }
                
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\n PLEASE RE-ENTER VALUE.");
                }
            }
            
        }
    }

}

