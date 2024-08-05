using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class RackInitialization
    {
        List<RackDetails> obj = new List<RackDetails>();
        List<PathInitialization> objPath = new List<PathInitialization>();

        public RackInitialization()
        {
            obj.Add(new RackDetails { RackNumber = "Rack 1", Article = new List<string>() { "Article 1", "Article 2" } });
            obj.Add(new RackDetails { RackNumber = "Rack 2", Article = new List<string>() { "Article 3", "Article 4" } });
            obj.Add(new RackDetails { RackNumber = "Rack 3", Article = new List<string>() { "Article 5", "Article 6" } });
            obj.Add(new RackDetails { RackNumber = "Rack 4", Article = new List<string>() { "Article 7", "Article 8" } });
            obj.Add(new RackDetails { RackNumber = "Rack 5", Article = new List<string>() { "Article 9", "Article 10" } });

            objPath.Add(new PathInitialization { From = 1, To = 2, Distance = 4 });
            objPath.Add(new PathInitialization { From = 1, To = 4, Distance = 6 });
            objPath.Add(new PathInitialization { From = 1, To = 5, Distance = 8 });
            objPath.Add(new PathInitialization { From = 2, To = 5, Distance = 5 });
            objPath.Add(new PathInitialization { From = 4, To = 3, Distance = 10 });
            objPath.Add(new PathInitialization { From = 4, To = 5, Distance = 1 });
        }

        public void FindShortest(string Article)
        {
            int index = 0, indexOfValue = 0, Distance1 = 0, From = 0, To = 0, hasFound = 0;
            foreach (var value in obj)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (value.Article[i] == Article)
                        indexOfValue = index;
                }
                index++;
            }

            indexOfValue = indexOfValue + 1;

            if (Article == "Article 1" || Article == "Article 2")
            {
                Console.WriteLine(Article);
                Console.WriteLine("Start -> Rack 1");
                Console.WriteLine("Distance {0}", 1);
                hasFound = 1;
            }

            if (hasFound == 0)
            {
                var path = objPath.Where(x => x.To == indexOfValue);
                foreach (var value in path)
                {
                    if (Distance1 == 0)
                    {
                        Distance1 = value.Distance;
                        From = value.From;
                        To = value.To;
                    }

                    if (Distance1 > value.Distance)
                    {
                        Distance1 = value.Distance;
                        From = value.From;
                        To = value.To;
                    }
                }

                if (From != 1)
                {
                    var newPath = objPath.Where(x => x.From == 1 && x.To == From);
                    Console.WriteLine(Article);
                    Console.WriteLine("Start -> Rack 1 -> Rack {0} -> Rack {1}", From, indexOfValue);
                    Console.WriteLine("Distance {0}", Convert.ToString(1 + Distance1 + newPath.ToList()[0].Distance));
                }
                else
                {
                    Console.WriteLine(Article);
                    Console.WriteLine("Start -> Rack 1 -> Rack {0}", To);
                    Console.WriteLine("Distance {0}", Convert.ToString(1 + Distance1));
                }
            }
        }
    }
}
