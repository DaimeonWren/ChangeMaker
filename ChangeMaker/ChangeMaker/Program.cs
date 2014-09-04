using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            CM(3.18);
            CM(156.37);
            CM(0.99);
            CM(12.93);
            Console.ReadKey();
        }
        /// <summary>
        /// Create my function 
        /// </summary>
        /// <param name="input"></param>
        static void CM(double input) 
        {
            // double allows you to have desmial
            double total = input;
            int Dred = 0;
            int fif = 0;
            int twen = 0;
            int ten = 0;
            int five = 0;
            int dol = 0;
            int Q = 0;
            int D = 0;
            int N = 0;
            int P = 0;
           // I create several while loops 
            while (total > 100.00) 
            {
                total -= 100.00;
                Dred++;
            }
            while (total > 50.00)
            {
                total -= 50.00;
                fif++;
            }
            while (total > 20.00)
            {
                total -= 20.00;
                twen++;
            }
            while (total > 10.00)
            {
                total -= 10.00;
                ten++;
            }
            while (total > 5.00)
            {
                total -= 5.00;
                five++;
            }
            while (total > 1.00)
            {
                total -= 1.00;
                dol++;
            }   

            while(total > 0.25)
            {
                total -= 0.25;
                Q++;
            }
            while (total > 0.1) 
            {
                total -= 0.1;
                D++;
            }
            while (total > 0.05) 
            {
                total -= 0.05;
                N++;
            }
            while (total > 0.01) 
            {
                total -= 0.01;
                P++;
            }
            // Then I place all my int's into the console
            Console.WriteLine("Amount: $" + input+ "\nHundereds: "+ Dred+ "\nFiftys: "+ fif +"\nTwenty: "+ twen +"\nTens: "+ ten +"\nFives: "+ five + "\nDollars: "+ dol +"\nQuarter: "+ Q +"\nDimes: "+ D + "\nNickels: " + N + "\nPennies: " + P + "\n");

        }
    }
}
