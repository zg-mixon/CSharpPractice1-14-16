using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructors
{
    class ConstructorYeah
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        public string Description { get; }


        public ConstructorYeah(string name, decimal price, int unitsInStock, string description=null)
        {
            this.Name = name;
            this.Price = price;
            this.UnitsInStock = unitsInStock;
            this.Description = description;


        }
    }
}
