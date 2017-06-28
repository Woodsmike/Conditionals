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
            Console.WriteLine("How many people in your party?");
            int numberOfPeople = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in your total bill.");
            double totalBill = double.Parse(Console.ReadLine());
            
            
            double moreDiscountTotal = (totalBill - (totalBill * .10d));
            double lessDiscountTotal = (totalBill - (totalBill * .05d));

            if (totalBill >= 50d)
            {
                Console.WriteLine("Total with discount: $" + moreDiscountTotal);
            }
            else
            {
                Console.WriteLine("Total with discount: $" + lessDiscountTotal);
            }

           
        }
    }
}
