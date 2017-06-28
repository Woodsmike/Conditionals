using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //have the user enter amount of people and their total bill
            Console.WriteLine("Thank you for dining at our restaurant?");
            Console.WriteLine("How many people are in your party?");
            int numberOfPeople = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter in your total bill.");
            double totalBill = double.Parse(Console.ReadLine());
            
            //set variables for the discount depending on the amount of total bill
            double moreDiscountTotal = (totalBill - (totalBill * .10d));
            double lessDiscountTotal = (totalBill - (totalBill * .05d));
            double billSplit;

            //figure the discounted amount for the total bill
            if (totalBill >= 50d)
            {
                Console.WriteLine("You received a 10% discount.");
                Console.WriteLine("Total with your discount: $" + moreDiscountTotal);
                billSplit = moreDiscountTotal / numberOfPeople;
                Console.WriteLine("Each person in your party will pay $" + billSplit);
            }
            else
            {
                Console.WriteLine("You received a 5% discount.");
                Console.WriteLine("Total with your discount: $" + lessDiscountTotal);
                billSplit = lessDiscountTotal / numberOfPeople;
                Console.WriteLine("Each person in your party will pay $" + billSplit);
            }
        }
    }
}
