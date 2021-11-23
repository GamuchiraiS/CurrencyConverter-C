using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            decimal amount;
            int convertFrom, convertTo;
            //user information
            Console.Write("Enter the amount: ");
            amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please select the number for the currency you are converting from: ");
            Console.WriteLine("1. United States Dollar \n2. South African Rand \n3. Euro \n4. Bitcoin");
            convertFrom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please select the number for the currency you are converting to: ");
            Console.WriteLine("1. United States Dollar \n2. South African Rand \n3. Euro \n4. Bitcoin");
            convertTo = Convert.ToInt32(Console.ReadLine());
            CurrencyConverter cc = new CurrencyConverter(amount, convertFrom, convertTo);
            Console.Write("Converted Amount: " + cc.CalculateCurrency());

            Console.ReadKey();
        }
    }
}
