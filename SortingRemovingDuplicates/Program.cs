using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingRemovingDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> letters = new List<char>();
            Random rand = new Random();
            char letter = ' ';

            //populating list with random letters
            for (int i = 0; i < 30; i++)
            {
                //65 and 91 are A-Z at ASCII Character
                letter = (char)rand.Next(65, 91);
                letters.Add(letter);
            }

            foreach (var element in letters)
                Console.Write(element + " ");
                Console.WriteLine();

            //sort ascending
            var query = from lt in letters
                        orderby lt ascending
                        select lt;

            foreach (var e in query)
                Console.Write(e + " ");
                Console.WriteLine();

            //sort descending
            var query2 = from lt in letters
                         orderby lt descending
                         select lt;

            foreach (var e in query2)
                Console.Write(e + " ");
                Console.WriteLine();

            //remove duplicates
            var query3 = (from lt in letters
                          orderby lt ascending
                          select lt).Distinct();

            foreach (var e in query3)
                Console.Write(e + " ");
                Console.WriteLine();

            Console.ReadLine();
        }
    }
}
