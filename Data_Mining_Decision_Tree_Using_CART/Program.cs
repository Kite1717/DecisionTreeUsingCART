using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Mining_Decision_Tree_Using_CART
{
    class Program
    {
        static void Main(string[] args)
        {

            DataEditor.GetData();
            DataEditor.MakeDataUnique();

            Cart cart = new Cart()
            Console.ReadKey();

        }
    }
}
