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
            //Console.WriteLine("Thank you for dining at our restaurant?");
            //Console.WriteLine("How many people are in your party?");
            //int numberOfPeople = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter in your total bill.");
            //double totalBill = double.Parse(Console.ReadLine());

            ////set variables for the discount depending on the amount of total bill
            //double moreDiscountTotal = (totalBill - (totalBill * .10d));
            //double lessDiscountTotal = (totalBill - (totalBill * .05d));
            //double billSplit;

            ////figure the discounted amount for the total bill
            //if (totalBill >= 50d)
            //{
            //    Console.WriteLine("You received a 10% discount.");
            //    Console.WriteLine("Total with your discount: $" + moreDiscountTotal);
            //    billSplit = moreDiscountTotal / numberOfPeople;
            //    Console.WriteLine("Each person in your party will pay $" + billSplit);
            //}
            //else
            //{
            //    Console.WriteLine("You received a 5% discount.");
            //    Console.WriteLine("Total with your discount: $" + lessDiscountTotal);
            //    billSplit = lessDiscountTotal / numberOfPeople;
            //    Console.WriteLine("Each person in your party will pay $" + billSplit);

            string wordNumber = "Eleven";
            switch (wordNumber)
            {
                case "Zero": Console.WriteLine(0);
                break;
                case "One": Console.WriteLine(1);
                break;
                case "Two": Console.WriteLine(2);
                break;
                case "Three": Console.WriteLine(3);
                break;
                case "Four": Console.WriteLine(4);
                break;
                case "Five": Console.WriteLine(5);
                break;
                case "Six": Console.WriteLine(6);
                break;
                case "Seven": Console.WriteLine(7);
                break;
                case "Eight": Console.WriteLine(8);
                break;
                case "Nine": Console.WriteLine(9);
                break;
                case "Ten": Console.WriteLine(10);
                break;
                default: Console.Write("Error  ");
                break;
            }
        }
    }
}
