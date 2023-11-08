using System.Threading.Channels;

namespace konzolosOrganization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ceg> cegek = new List<Ceg>();

            File.ReadAllLines("organizations100.csv").Skip(1).ToList().ForEach(x => cegek.Add(new Ceg(x)));

            //1. feladat
            Console.Write("1. feladat: ");
            Console.WriteLine(cegek.Where(x => x.Founded == 2012).Count());

            //2. feladat

            //cegek.Where(x => x.Industry == "Secondary Education").Sum(x => x.Employees) > cegek.Where(x => x.Industry == "Military Industry").Sum(x => x.Employees) ? Console.WriteLine("1") : Console.WriteLine("2");
            Console.Write("2. feladat: ");
            if (cegek.Where(x => x.Industry == "Primary / Secondary Education").Sum(x => x.Employees) != cegek.Where(x => x.Industry == "Military Industry").Sum(x => x.Employees))
            {
                if (cegek.Where(x => x.Industry == "Primary / Secondary Education").Sum(x => x.Employees) > cegek.Where(x => x.Industry == "Military Industry").Sum(x => x.Employees))
                {
                    Console.WriteLine("Primary / Secondary Education-ben többen dolgoznak.");
                }
                else
                {
                    Console.WriteLine("Military Industry-ban többen dolgoznak.");
                }
            }
            else
            {
                Console.WriteLine("Egyenlőek!");
            }

            //3.feladat
            Console.WriteLine("3. feladat: ");
            cegek.GroupBy(x =>x.Founded).ToList().OrderBy(x => x.Key).ToList().ForEach(x=> Console.WriteLine($"{x.Key} Évben {x.Count()} cég jött létre."));

            //4. feladat
            Console.WriteLine("4. feladat: ");
            cegek.GroupBy(x => x.Country).OrderByDescending(x => x.Count()).ThenBy(x=>x.Key).Take(5).ToList().ForEach(x=>Console.WriteLine($"{x.Key}ba {x.Count()} cég van bejegyezve."));

        }
    }
}