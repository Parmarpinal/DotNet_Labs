using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Hospital
    {
        public void hospitalDetails()
        {
            Console.WriteLine("Hospital details");
        }
    }
    class Apollo:Hospital
    {
        public void hospitalDetails()
        {
            Console.WriteLine("Apollo hospital");
        }
    }
    class Wockhardt : Hospital
    {
        public void hospitalDetails()
        {
            Console.WriteLine("Wockhardt hospital");
        }
    }
    class Gokul_Superspeciality : Hospital
    {
        public void hospitalDetails()
        {
            Console.WriteLine("Gokul_Superspeciality hospital");
        }
    }
}
