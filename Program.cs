using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names =
            {
                 "Life is Beautiful",
                "Arshika Agarwal",
                "Seven Pounds",
                "Rupali Agarwal",
                "Pearl Solutions",
                "Vamika Agarwal",
                "Vidya Vrat Agarwal",
                "C-Sharp Corner Mumbai Chapter"
            };
            //Linq query  
            IEnumerable<string> namesOfPeople = from name in names
                                                where name.Length <= 16
                                                select name;
            //OR
            /*
            var namesOfPeople = from name in names
                        where name.Length <= 16
                        select name;
            */
            foreach (var name in namesOfPeople)
            {
                Console.WriteLine(name + "\n");
            }
            Console.ReadKey();
        }
    }
}
