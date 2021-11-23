using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class CurrencyConverter
    {
        public decimal amount, result;
        public int convertFrom, convertTo;

        //constructor
        public CurrencyConverter(decimal a, int cf, int ct)
        {
            amount = a;
            convertFrom = cf;
            convertTo = ct;
            result = 0.0M;
        }

        public decimal CalculateCurrency()
        {
            //If the user is converting from USD to USD
            if (convertFrom == 1 && convertTo == 1)
            {
                Console.Write("You can't convert between the same currencies");
            }
            //If the user is converting from USD to ZAR
            else if (convertFrom == 1 && convertTo == 2)
            {
                result = amount * 14.83M;
            }
            //If the user is converting from USD to EURO
            else if (convertFrom == 1 && convertTo == 3)
            {
                result = amount * 0.85M;
            }
            //If the user is converting from USD to Bitcoin
            else if (convertFrom == 1 && convertTo == 4)
            {
                result = amount * 0.000023M;
            }

            //--------------------------------------------------------------
            //If the user is converting from ZAR to ZAR
            else if (convertFrom == 2 && convertTo == 2)
            {
                Console.Write("You can't convert between the same currencies");
            }
            //If the user is converting from ZAR to USD
            else if (convertFrom == 2 && convertTo == 1)
            {
                result = amount * 0.068M;
            }
            //If the user is converting from ZAR to EURO
            else if (convertFrom == 2 && convertTo == 3)
            {
                result = amount * 0.058M;
            }
            //If the user is converting from ZAR to Bitcoin
            else if (convertFrom == 2 && convertTo == 4)
            {
                result = amount * 0.0000015M;
            }

            //---------------------------------------------------------------------
            //If the user is converting from EURO --> EURO
            else if (convertFrom == 3 && convertTo == 3)
            {
                Console.Write("You can't convert between the same currencies");
            }
            //If the user is converting from EURO --> USD
            else if (convertFrom == 3 && convertTo == 1)
            {
                result = amount * 1.17M;
            }
            //If the user is converting from EURO --> ZAR
            else if (convertFrom == 3 && convertTo == 2)
            {
                result = amount * 17.36M;
            }
            //If the user is converting EURO --> Bitcoin
            else if (convertFrom == 3 && convertTo == 4)
            {
                result = amount * 0.000024M;
            }
            //--------------------------------------------------------------------
            //If the user is converting from Bitcoin --> Bitcoin
            else if (convertFrom == 4 && convertTo == 4)
            {
                Console.Write("You can't convert between the same currencies");
            }
            //If the user is converting from Bitcoin --> USD
            else if (convertFrom == 4 && convertTo == 1)
            {
                result = amount * 43852.90M;
            }
            //If the user is converting from Bitcoin --> ZAR
            else if (convertFrom == 4 && convertTo == 2)
            {
                result = amount * 650263.96M;
            }
            //If the user is converting Bitcoin --> EURO
            else if (convertFrom == 4 && convertTo == 3)
            {
                result = amount * 37408.94M;
            }
            else
            {
                Console.WriteLine("Please try again.");
            }
            //round off to 2 decimal places
            return Math.Round(result, 2);
        }
    }
}
