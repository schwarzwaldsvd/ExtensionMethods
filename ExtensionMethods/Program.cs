using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main()
        {
            string name = "FirstName";
            // using extension method syntax
            string result = name.ToggleFirstLetterCase();

            // using wrapper class syntax
            //string result = StringHelper.ToggleFirstLetterCase(name);
            Console.WriteLine(result);
            

            List<int> numbers = new List<int>{ 1,2,3,4,5,6,7,8,9,10 };
            IEnumerable<int> evenNumbers = numbers.Where(n => n % 2 == 0);
            IEnumerable<int> evenNumbersActual = Enumerable.Where(numbers, n => n % 2 == 0); 
            
            foreach (int evenNumber in evenNumbers)
            {
                Console.WriteLine(evenNumber);
            }
            //Console.ReadKey();
        }
    }
}
