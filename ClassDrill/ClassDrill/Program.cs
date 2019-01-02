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

            Console.WriteLine("The number you are working with today is " + number.Value + ".");
            Console.ReadLine();

        }
    }
}
