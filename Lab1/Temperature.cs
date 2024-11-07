using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Temperature
    {
        double celcius, ferenhit;

        public void celciusToFerenhit()
        {
            Console.WriteLine("Enter celcius :");
            celcius = Convert.ToDouble(Console.ReadLine());
            ferenhit = (celcius * 9)/5 + 32;
            Console.WriteLine($"{celcius} celcius = {ferenhit} ferenhit");
        }
        public void ferenhitToCelcius()
        {
            Console.WriteLine("Enter ferenhit :");
            ferenhit = Convert.ToDouble(Console.ReadLine());
            celcius = (ferenhit - 32) * 5/9;
            Console.WriteLine($"{ferenhit} ferenhit = {celcius} celcius");
        }
    }
}
