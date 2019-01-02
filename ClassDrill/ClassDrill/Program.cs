using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter an interger you would like to work with:");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            Number number = new Number();
            number.Value = enteredNumber;
            number = Add(number);
            number = Divide(number);
            number = Multiply(number);

            Console.WriteLine("After processing, your number is now " + number.Value + ".");
            Console.ReadLine();

        }

        public static Number Add(Number number)
        {

            int tempAddnumber = number.Value + 10;
            number.Value = tempAddnumber;
            return number;

        }

        public static Number Divide(Number number)
        {

            int tempDividenumber = number.Value / 2;
            number.Value = tempDividenumber;
            return number;

        }

        public static Number Multiply(Number number)
        {
            int tempMultiplynumber = number.Value * 20;
            number.Value = tempMultiplynumber;
            return number;
        }
    }
}
