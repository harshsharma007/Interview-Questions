using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            RackInitialization rackInitialization = new RackInitialization();
            Console.WriteLine("Which article you want to find?");
            string article = Console.ReadLine();

            if (article.Contains("Article"))
                rackInitialization.FindShortest(article);
            else
                rackInitialization.FindShortest("Article " + article);

            Console.ReadLine();
        }
    }
}
