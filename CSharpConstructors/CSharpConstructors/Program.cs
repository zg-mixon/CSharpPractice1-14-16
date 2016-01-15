using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new ConstructorYeah("Cat", 23m, 27);
            product1.Name = "Porcupine";
            
            Debug.Assert(product1.Description == null, "There should be no decription!");
            Console.WriteLine("Product one is {0} and it has a price of {1:c}", product1.Name, product1.Price);
            Console.ReadLine();
        }
    }
}
