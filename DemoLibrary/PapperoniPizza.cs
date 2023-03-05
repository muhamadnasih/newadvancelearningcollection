using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
     public class PapperoniPizza : IPizza
    {

        public void Preparation()
        {
            Console.WriteLine("Insert Papperoni");
        }
    }

    public class MagarittaPizza : IPizza
    {
        public void Preparation()
        {
            Console.WriteLine("Add cheese and sauce tomato");
        }
    }
}
